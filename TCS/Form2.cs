using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TCS
{
    public partial class Form2 : Form
    {
        int current_trial_no = 1;
        List<Cue> cuesList = null;
        Cue currentCue = null;
        int NumberOfCues;
        int CurrentCueIndex = 0;
        CsvWriter csvWriter = new CsvWriter();
        bool played = false;

        public int ConnectedDeviceID;
        DateTime startTime;
        DateTime endTime;
  

        public Form2(int ConnectedDevice, List<Cue> cuesList, int NumberOfCues)
        {
            InitializeComponent();
            //Tdk.TdkInterface.InitializeTI();

            this.ConnectedDeviceID = ConnectedDevice;
            this.cuesList = cuesList;
            this.NumberOfCues = NumberOfCues;
            Console.WriteLine(NumberOfCues);
            Console.WriteLine(cuesList.Count);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //var Form3 = new Form3(ConnectedDeviceID, cuesList, NumberOfCues);
            //Form3.Show();

            //DEBUGGING
            Console.WriteLine(currentCue.TypeoOfChange);


            #region Variables

            played = true;
            this.startTime = DateTime.Now;
            int cueIndex = CurrentCueIndex;
            this.currentCue = cuesList[cueIndex];

            int startChange = currentCue.StartChangeAfterPulseNumber;
            string typeOfChange = currentCue.TypeoOfChange;

            //tactors
            int tactor = currentCue.StartingTactorLocation;

            //parameters
            int frequency = currentCue.StartingFrequency;
            int pulseDuration = currentCue.StartingPulseDuration;
            int pulseDuration2 = currentCue.EndingPulseDuration;
            int gain = currentCue.StartingGain;

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

            #endregion Variables


            
 
            for (int i = 0; i < startChange; i++)
            {
                Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration);
                Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration, Tdk.TdkDefines.RampLinear, 0);
                Tdk.TdkInterface.Pulse(0, tactor, pulseDuration, 0);
            }
            for (int i = 0; i < 8 - startChange; i++)
            {
                Tdk.TdkInterface.ChangeFreq(0, tactor, frequency, pulseDuration2);
                Tdk.TdkInterface.RampGain(0, tactor, gain, gain, pulseDuration2, Tdk.TdkDefines.RampLinear, 0);
                Tdk.TdkInterface.Pulse(0, tactor, pulseDuration2, 0);
            }  
        }

  

    }
}
