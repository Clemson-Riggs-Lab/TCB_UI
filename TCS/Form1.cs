﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;





namespace TCS
{
    public partial class TCSForm : Form
    {
        public static bool activeAction;
        private int ConnectedDeviceID = -1;
        List<Cue> cuesList = null;
        int NumberOfCues;
        int CurrentCueIndex;
        int pulsesBeforeChange = 3;
        CsvWriter csvWriter = new CsvWriter();
        string[] args = Environment.GetCommandLineArgs();
        private System.Windows.Forms.Timer timer1;
        bool timed = false;
        DateTime simStartTime;
        private bool fileloaded;

        public TCSForm()
        {
            
            InitializeComponent();
            selectCueNumericUpDown.Enabled = false;
            playCueButton.Enabled = false;
            //To initialize the TDKInterface we need to call InitializeTI before we use any
            //of its functionality
            WriteMessageToGUIConsole("IntializeTI\n");
            CheckTDKErrors(Tdk.TdkInterface.InitializeTI());


            if (!String.IsNullOrEmpty(GetArg("-inputFilePath")))
            {
                if (bool.TryParse(GetArg("-simTimed"), out bool b))
                {
                    timed = b;

                }
                if (timed)
                {
                    if (DateTime.TryParse(GetArg("-simStartTime"), out DateTime s))
                    {
                        simStartTime = s;
                    }
                    else
                    {
                        simStartTime = DateTime.Now;
                    }
                }


                if (!String.IsNullOrEmpty(GetArg("-inputFilePath")))
                {
                    ReadFile(GetArg("-inputFilePath"), timed);
                }

                if (timed)
                {
                    InitTimer();
                    NextCueButton.Enabled = false;
                    selectCueNumericUpDown.Enabled = false;
                    playCueButton.Enabled = false;
                }
                ComPortComboBox.Enabled = false;

            }


        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            WriteMessageToGUIConsole("\nDiscover Started...\n");
            //Discovers all serial tactor devices and returns the amount found
            int ret = Tdk.TdkInterface.Discover((int)Tdk.TdkDefines.DeviceTypes.Serial);
            if (ret > 0)
            {
                WriteMessageToGUIConsole("Discover Found:\n");
                //populate combo box with discovered names
                for (int i = 0; i < ret; i++)
                {
                    //Gets the discovered device name at the index i
                    System.IntPtr discoveredNamePTR = Tdk.TdkInterface.GetDiscoveredDeviceName(i);
                    if (discoveredNamePTR != null)
                    {
                        string sComName = Marshal.PtrToStringAnsi(discoveredNamePTR);
                        WriteMessageToGUIConsole(sComName + "\n");
                        ComPortComboBox.Items.Add(sComName);
                        DiscoverButton.Enabled = false;
                        ConnectButton.Enabled = true;
                        }
                    else
                        WriteMessageToGUIConsole(Tdk.TdkDefines.GetLastEAIErrorString());
                }
                ComPortComboBox.SelectedIndex = 0;
                
            }
            else
            {
                WriteMessageToGUIConsole("Discover Failed:\n");
                WriteMessageToGUIConsole(Tdk.TdkDefines.GetLastEAIErrorString());
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedComPort = ComPortComboBox.SelectedItem.ToString();
                WriteMessageToGUIConsole("Connecting to com port " + selectedComPort + "\n");
                //Connect connects to the tactor controller via serial with the given name
                //we should be hooking up a response callback but for simplicity of the 
                //tutorial we wont be. Reference the ResponseCallback tutorial for more information
                int ret = Tdk.TdkInterface.Connect(selectedComPort,
                                                   (int)Tdk.TdkDefines.DeviceTypes.Serial,
                                                    System.IntPtr.Zero);
                if (ret >= 0)
                {
                    ConnectedDeviceID = ret;
                    DiscoverButton.Enabled = false;
                    ConnectButton.Enabled = false;

                    if (fileloaded == false)
                    {
                        BrowseFileButton.Enabled = true;
                        NextCueButton.Enabled = false;
                    }
                    else
                    {
                        BrowseFileButton.Enabled = false;

                        if (timed)
                        {
                            NextCueButton.Enabled = false;
                        }
                        else
                        {
                            NextCueButton.Enabled = true;
                        }
                    }

                }
                else
                {
                    WriteMessageToGUIConsole(Tdk.TdkDefines.GetLastEAIErrorString());
                }
            }
            catch
            {
                DiscoverButton_Click(new object(), new EventArgs());
            }
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                ReadFile(file);                        }
            WriteMessageToGUIConsole("File loaded? " +result.ToString() + "\n");
            Console.WriteLine(result); // <-- For debugging use.
    }

        private void ReadFile(string file,bool timed=false)
        {
            try
            {
                CSVReader reader = new CSVReader();
                cuesList = reader.Load(file,timed, simStartTime);
                NumberOfCues = reader.NumRows();
                selectCueNumericUpDown.Maximum = NumberOfCues;
                CurrentCueIndex = 0;
                string text = File.ReadAllText(file);
                NextCueButton.Enabled = true;
                fileloaded = true;
                BrowseFileButton.Enabled = false;
                selectCueNumericUpDown.Enabled = true;
                playCueButton.Enabled = true;
                SetCueText(cuesList[0]);
            }
            catch (IOException)
            {
                WriteMessageToGUIConsole("Couldnt Load File, make sure it is not opened and try again\n");
            }
        }

        private void NextCueButton_Click(object sender, EventArgs e)
        {
           
            if (cuesList != null && CurrentCueIndex < NumberOfCues)
            {
                WriteMessageToGUIConsole("Played Cue#"+(CurrentCueIndex+1)+ "\n");
                PlayCue(CurrentCueIndex);
                CurrentCueIndex++;
                if (CurrentCueIndex < NumberOfCues)
                {
                    SetCueText(cuesList[CurrentCueIndex]);
                }
                

            }
            else if( NumberOfCues==CurrentCueIndex)
                WriteMessageToGUIConsole("No More Cues \n");
        }

        private void PlayCue(int cueIndex)
        {
            
            DateTime startTime = DateTime.Now;
            activeAction = true;
            Cue currentCue = cuesList[cueIndex];
            int startPulseBreak = currentCue.StartingPulseDuration + currentCue.StartingISI;
            int endPulseBreak = currentCue.EndingPulseDuration + currentCue.EndingISI;
            int transitionPulses = currentCue.EndChangeAfterPulseNumber - currentCue.StartChangeAfterPulseNumber;
            float gainIncrement = 0;
            float freqIncrement = 0;
            if (transitionPulses != 0)
            {
                gainIncrement = (currentCue.EndingGain - currentCue.StartingGain) / (transitionPulses);
                freqIncrement = (currentCue.EndingFrequency - currentCue.StartingFrequency) / (transitionPulses);
            }


            if (currentCue.TypeoOfChange == "Temporal")
            {   //Temporal
                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
                {                  
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
            }


            else if (currentCue.TypeoOfChange == "Spatial")
            {   //Spatial
                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
            }

            else if (currentCue.TypeoOfChange == "Intensity")
            {   //Intensity
                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }

                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
                    currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);

                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                // for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber - 1 - transitionPulses; i++)// testing only ( problem where intensity only presents 7 vibrations instead of 8)
                for (int i = 0; i < 8 - currentCue.EndChangeAfterPulseNumber  - transitionPulses; i++)
                {

                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
            }
            else if (currentCue.TypeoOfChange == "Int+Temp")
            {   //Intensity + Temporal

                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
                    currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber - 1 - transitionPulses; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.EndingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
            }
            else if (currentCue.TypeoOfChange == "Spat+Temp")
            { //Spatial + Temporal
                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);

                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.EndingPulseDuration);
                    Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.EndingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, endPulseBreak);
                    Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.EndingPulseDuration, 0);
                    if (activeAction == false)
                    {
                        break;
                    }
                }

            }
            else
            {   //Intensity + Spatial
                for (int i = 0; i < currentCue.StartChangeAfterPulseNumber + 1; i++)
                {
                    if (i == currentCue.StartChangeAfterPulseNumber)
                    {
                         currentCue.StartingTactorLocation = currentCue.EndingTactorLocation;
                    }
                    Tdk.TdkInterface.ChangeFreq(0,  currentCue.StartingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0,  currentCue.StartingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0,  currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < transitionPulses; i++)
                {
                    currentCue.StartingGain = currentCue.StartingGain + Convert.ToInt32(gainIncrement);
                    currentCue.StartingFrequency = currentCue.StartingFrequency + Convert.ToInt32(freqIncrement);
                    Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
                for (int i = 0; i < 8 - currentCue.StartChangeAfterPulseNumber - 1 - transitionPulses; i++)
                {
                    Tdk.TdkInterface.ChangeFreq(0, currentCue.EndingTactorLocation, currentCue.StartingFrequency, currentCue.StartingPulseDuration);
                    Tdk.TdkInterface.RampGain(0, currentCue.EndingTactorLocation, currentCue.StartingGain, currentCue.StartingGain, currentCue.StartingPulseDuration, Tdk.TdkDefines.RampLinear, 0);
                    toggleOn(0, startPulseBreak);
                    Tdk.TdkInterface.Pulse(0, currentCue.EndingTactorLocation, currentCue.StartingPulseDuration, 0);
                    //Debug.Log ("Gain: " + currentCue.StartingGain);
                    if (activeAction == false)
                    {
                        break;
                    }
                }
            }
            DateTime endTime = DateTime.Now;
            csvWriter.AddEvent(startTime.ToString("HH:mm:ss:ffff"), endTime.ToString("HH:mm:ss:ffff"), currentCue);
        }

       
        private void WriteMessageToGUIConsole(string msg)
        {
            ConsoleOutputRichTextBox.AppendText(msg);
        }

        private void TCS_FormClosed(object sender, FormClosedEventArgs e)
        {
            //closes up the connection to the tactor device with ConnectedBoardID
			CheckTDKErrors(Tdk.TdkInterface.Close(ConnectedDeviceID));
			//cleans up everyting associated witht the TActionManager. Unloads any TActions loaded
			CheckTDKErrors(Tdk.TdkInterface.ShutdownTI());
        }
        private void CheckTDKErrors(int ret)
        {
            //if a tdk method returns less then zero then we should display the last error
            //in the tdk interface
            if (ret < 0)
            {
                //the GetLastEAIErrorString returns a string that represents the last error code
                //recorded in the tdk interface.
                WriteMessageToGUIConsole(Tdk.TdkDefines.GetLastEAIErrorString());
            }
        }

        private void toggleOn(int id, int delay)
        {
            //tactorOn[id] = true;
            Thread.Sleep(delay);
            //tactorOn[id] = false;
        }


        private void playCueButton_Click(object sender, EventArgs e)
        {
            if (selectCueNumericUpDown.Value != 0)
            {
                CurrentCueIndex = Convert.ToInt32(selectCueNumericUpDown.Value) - 1;
                WriteMessageToGUIConsole("Played Cue# " + (CurrentCueIndex+1) + "\n");
                PlayCue(CurrentCueIndex);
                CurrentCueIndex++;
                selectCueNumericUpDown.Value = 0;
            }
            else
                WriteMessageToGUIConsole("Please select a valid cue number\n");
        }

        private void SetCueText(Cue CurrentCue)
        {
            newScreenNumberDataLabel.Text = CurrentCue.NewScreenNumber.ToString();
            cueNumberForInputDataLabel.Text = CurrentCue.CueNumberForInput.ToString();
            typeOfChangeDataLabel.Text= CurrentCue.TypeoOfChange;
            startingGainDataLabel.Text= CurrentCue.StartingGain.ToString();
            startingFrequencyDataLabel.Text= CurrentCue.StartingFrequency.ToString();
            endingGainDataLabel.Text= CurrentCue.EndingGain.ToString();
            endingFrequencyDataLabel.Text= CurrentCue.EndingFrequency.ToString();
            startTactorLocationDataLabel.Text= CurrentCue.StartingTactorLocation.ToString();
            endTactorLocationDataLabel.Text = CurrentCue.EndingTactorLocation.ToString();
            startingISIDataLabel.Text = CurrentCue.StartingISI.ToString();
            endingISIDataLabel.Text = CurrentCue.EndingISI.ToString();
            startingPulseDurationDataLabel.Text = CurrentCue.StartingPulseDuration.ToString();
            endingPulseDurationDataLabel.Text = CurrentCue.EndingPulseDuration.ToString();
            startChangeAfterPulseNumberDataLabel.Text = CurrentCue.StartChangeAfterPulseNumber.ToString();
            endChangeAfterPulseNumberDataLabel.Text = CurrentCue.EndChangeAfterPulseNumber.ToString();
            TactorNumDataLabel.Text = CurrentCue.TactorNum.ToString();
            ISILengthDataLabel.Text = CurrentCue.ISILength.ToString();
            TransientTypeDataLabel.Text = CurrentCue.TransientType;
            TransientTimingDataLabel.Text = CurrentCue.TransientTiming;
        }

        private void selectCueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(selectCueNumericUpDown.Value!=0)
            SetCueText(cuesList[ Convert.ToInt32(selectCueNumericUpDown.Value) - 1]);
        }


        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 50; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { if (CurrentCueIndex < NumberOfCues )
            {
                if (DateTime.Now > cuesList[CurrentCueIndex].presentTime)
                {
                    NextCueButton_Click(new object(), new EventArgs());
                }
                else
                {
                    TimeSpan delta = cuesList[CurrentCueIndex].presentTime - DateTime.Now;
                    DeltaTimeLable.Text = String.Format("{0:HH:mm:ss}", new DateTime(Math.Abs(delta.Ticks)));


                }
            }
        }

        private static string GetArg(string name)
        {
             var args = System.Environment.GetCommandLineArgs();
            //string[] args = new string[] { @"C: \Users\aalami\AppData\Local\Apps\2.0\1R5LV3B4.AGZ\C14O01W5.3L6\tcs...tion_ef6947fc02dca824_0001.0000_739ca3dc7315f599\TCS.exe",
            //    "-simTimed", "False", "-simStartTime", "-", "-inputFilePath", @"E:\Finished Simulations\Input files\TDK Input\TS2_PRE-TEST input file_V1.csv" };
            //string[] args = new string[] { @"C: \Users\aalami\AppData\Local\Apps\2.0\1R5LV3B4.AGZ\C14O01W5.3L6\tcs...tion_ef6947fc02dca824_0001.0000_ddcc3ffaee92dc1a\TCS.exe", "-simTimed","False",
            //"-simStartTime"," - ", "-inputFilePath",@"E:\Finished Simulations\Input files\TDK Input\TS2_experiment input file_V3.csv" };
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == name && args.Length > i + 1)
                {
                    return args[i + 1];
                }
            }
            return null;
        }

        private void TCSForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIntenseMatch_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var Form2 = new Form2(ConnectedDeviceID, cuesList, NumberOfCues);
            Form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            activeAction = true;
            Cue currentCue = cuesList[0];
            int startPulseBreak = currentCue.StartingPulseDuration + currentCue.ISILength;
            WriteMessageToGUIConsole("button click\n");
            

            Tdk.TdkInterface.Pulse(0, currentCue.StartingTactorLocation, currentCue.StartingPulseDuration, 0);
            toggleOn(0, startPulseBreak); // ISI length variable
            Tdk.TdkInterface.Pulse(0, 5, currentCue.StartingPulseDuration, 0);
        }
    }

}



