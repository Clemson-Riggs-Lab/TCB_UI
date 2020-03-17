namespace TCS
{
    partial class TCSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCSForm));
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.DiscoverButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.ConsoleOutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectCueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playCueButton = new System.Windows.Forms.Button();
            this.newScreenNumberDataLabel = new System.Windows.Forms.Label();
            this.newscreenNumberLabel = new System.Windows.Forms.Label();
            this.cueNumberForInputDataLabel = new System.Windows.Forms.Label();
            this.cueNumberForInputLabel = new System.Windows.Forms.Label();
            this.typeOfChangeDataLabel = new System.Windows.Forms.Label();
            this.TypeofchangeLabel = new System.Windows.Forms.Label();
            this.startingGainDataLabel = new System.Windows.Forms.Label();
            this.startingGainLabel = new System.Windows.Forms.Label();
            this.startingFrequencyDataLabel = new System.Windows.Forms.Label();
            this.startingFrequencyLabel = new System.Windows.Forms.Label();
            this.endingGainDataLabel = new System.Windows.Forms.Label();
            this.endingGainLabel = new System.Windows.Forms.Label();
            this.endingFrequencyDataLabel = new System.Windows.Forms.Label();
            this.endingFrequencyLabel = new System.Windows.Forms.Label();
            this.startTactorLocationLabel = new System.Windows.Forms.Label();
            this.startTactorLocationDataLabel = new System.Windows.Forms.Label();
            this.endTactorLocationDataLabel = new System.Windows.Forms.Label();
            this.endTactorLocationLabel = new System.Windows.Forms.Label();
            this.startingISIDataLabel = new System.Windows.Forms.Label();
            this.startingISILabel = new System.Windows.Forms.Label();
            this.endingISIDataLabel = new System.Windows.Forms.Label();
            this.endingISILabel = new System.Windows.Forms.Label();
            this.startingPulseDurationDataLabel = new System.Windows.Forms.Label();
            this.startingPulseDurationLabel = new System.Windows.Forms.Label();
            this.endingPulseDurationDataLabel = new System.Windows.Forms.Label();
            this.endingPulseDurationLabel = new System.Windows.Forms.Label();
            this.startChangeAfterPulseNumberDataLabel = new System.Windows.Forms.Label();
            this.startChangeAfterPulseNumberLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DeltaTimeLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextCueButton = new System.Windows.Forms.Button();
            this.btnIntenseMatch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tactorNumLabel = new System.Windows.Forms.Label();
            this.TactorNumDataLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.endChangeAfterPulseNumberDataLabel = new System.Windows.Forms.Label();
            this.EndChangeAfterPulseNumberLabel = new System.Windows.Forms.Label();
            this.ISILengthLabel = new System.Windows.Forms.Label();
            this.TransientTypeLabel = new System.Windows.Forms.Label();
            this.TransientTimingLabel = new System.Windows.Forms.Label();
            this.ISILengthDataLabel = new System.Windows.Forms.Label();
            this.TransientTypeDataLabel = new System.Windows.Forms.Label();
            this.TransientTimingDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectCueNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.FormattingEnabled = true;
            this.ComPortComboBox.Location = new System.Drawing.Point(102, 18);
            this.ComPortComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(304, 26);
            this.ComPortComboBox.TabIndex = 0;
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(18, 22);
            this.ComPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(80, 18);
            this.ComPortLabel.TabIndex = 1;
            this.ComPortLabel.Text = "Com Port";
            // 
            // DiscoverButton
            // 
            this.DiscoverButton.Location = new System.Drawing.Point(22, 55);
            this.DiscoverButton.Margin = new System.Windows.Forms.Padding(4);
            this.DiscoverButton.Name = "DiscoverButton";
            this.DiscoverButton.Size = new System.Drawing.Size(155, 61);
            this.DiscoverButton.TabIndex = 2;
            this.DiscoverButton.Text = "Discover";
            this.DiscoverButton.UseVisualStyleBackColor = true;
            this.DiscoverButton.Click += new System.EventHandler(this.DiscoverButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Location = new System.Drawing.Point(199, 55);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(161, 61);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Enabled = false;
            this.BrowseFileButton.Location = new System.Drawing.Point(22, 124);
            this.BrowseFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(155, 61);
            this.BrowseFileButton.TabIndex = 4;
            this.BrowseFileButton.Text = "Browse File";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // ConsoleOutputRichTextBox
            // 
            this.ConsoleOutputRichTextBox.Location = new System.Drawing.Point(22, 195);
            this.ConsoleOutputRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConsoleOutputRichTextBox.Name = "ConsoleOutputRichTextBox";
            this.ConsoleOutputRichTextBox.ReadOnly = true;
            this.ConsoleOutputRichTextBox.Size = new System.Drawing.Size(338, 170);
            this.ConsoleOutputRichTextBox.TabIndex = 7;
            this.ConsoleOutputRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 645);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Go to Cue #:";
            // 
            // selectCueNumericUpDown
            // 
            this.selectCueNumericUpDown.Location = new System.Drawing.Point(533, 640);
            this.selectCueNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.selectCueNumericUpDown.Name = "selectCueNumericUpDown";
            this.selectCueNumericUpDown.Size = new System.Drawing.Size(48, 28);
            this.selectCueNumericUpDown.TabIndex = 10;
            this.selectCueNumericUpDown.ValueChanged += new System.EventHandler(this.selectCueNumericUpDown_ValueChanged);
            // 
            // playCueButton
            // 
            this.playCueButton.Location = new System.Drawing.Point(584, 640);
            this.playCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.playCueButton.Name = "playCueButton";
            this.playCueButton.Size = new System.Drawing.Size(61, 28);
            this.playCueButton.TabIndex = 11;
            this.playCueButton.Text = "Play Cue";
            this.playCueButton.UseVisualStyleBackColor = true;
            this.playCueButton.Click += new System.EventHandler(this.playCueButton_Click);
            // 
            // newScreenNumberDataLabel
            // 
            this.newScreenNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newScreenNumberDataLabel.AutoSize = true;
            this.newScreenNumberDataLabel.Location = new System.Drawing.Point(295, 10);
            this.newScreenNumberDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newScreenNumberDataLabel.Name = "newScreenNumberDataLabel";
            this.newScreenNumberDataLabel.Size = new System.Drawing.Size(0, 18);
            this.newScreenNumberDataLabel.TabIndex = 6;
            this.newScreenNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newscreenNumberLabel
            // 
            this.newscreenNumberLabel.AutoSize = true;
            this.newscreenNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.newscreenNumberLabel.Location = new System.Drawing.Point(5, 1);
            this.newscreenNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newscreenNumberLabel.Name = "newscreenNumberLabel";
            this.newscreenNumberLabel.Size = new System.Drawing.Size(197, 36);
            this.newscreenNumberLabel.TabIndex = 7;
            this.newscreenNumberLabel.Text = "Cue # (New screen#) :";
            this.newscreenNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cueNumberForInputDataLabel
            // 
            this.cueNumberForInputDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cueNumberForInputDataLabel.AutoSize = true;
            this.cueNumberForInputDataLabel.Location = new System.Drawing.Point(286, 47);
            this.cueNumberForInputDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cueNumberForInputDataLabel.Name = "cueNumberForInputDataLabel";
            this.cueNumberForInputDataLabel.Size = new System.Drawing.Size(17, 18);
            this.cueNumberForInputDataLabel.TabIndex = 8;
            this.cueNumberForInputDataLabel.Text = " ";
            this.cueNumberForInputDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cueNumberForInputLabel
            // 
            this.cueNumberForInputLabel.AutoSize = true;
            this.cueNumberForInputLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cueNumberForInputLabel.Location = new System.Drawing.Point(5, 38);
            this.cueNumberForInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cueNumberForInputLabel.Name = "cueNumberForInputLabel";
            this.cueNumberForInputLabel.Size = new System.Drawing.Size(197, 36);
            this.cueNumberForInputLabel.TabIndex = 9;
            this.cueNumberForInputLabel.Text = "Cue Number for Input:";
            this.cueNumberForInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeOfChangeDataLabel
            // 
            this.typeOfChangeDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeOfChangeDataLabel.AutoSize = true;
            this.typeOfChangeDataLabel.Location = new System.Drawing.Point(286, 84);
            this.typeOfChangeDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeOfChangeDataLabel.Name = "typeOfChangeDataLabel";
            this.typeOfChangeDataLabel.Size = new System.Drawing.Size(17, 18);
            this.typeOfChangeDataLabel.TabIndex = 10;
            this.typeOfChangeDataLabel.Text = " ";
            this.typeOfChangeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeofchangeLabel
            // 
            this.TypeofchangeLabel.AutoSize = true;
            this.TypeofchangeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeofchangeLabel.Location = new System.Drawing.Point(5, 75);
            this.TypeofchangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeofchangeLabel.Name = "TypeofchangeLabel";
            this.TypeofchangeLabel.Size = new System.Drawing.Size(143, 36);
            this.TypeofchangeLabel.TabIndex = 11;
            this.TypeofchangeLabel.Text = "Type Of Change:";
            this.TypeofchangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingGainDataLabel
            // 
            this.startingGainDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingGainDataLabel.AutoSize = true;
            this.startingGainDataLabel.Location = new System.Drawing.Point(286, 121);
            this.startingGainDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingGainDataLabel.Name = "startingGainDataLabel";
            this.startingGainDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startingGainDataLabel.TabIndex = 12;
            this.startingGainDataLabel.Text = " ";
            this.startingGainDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingGainLabel
            // 
            this.startingGainLabel.AutoSize = true;
            this.startingGainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingGainLabel.Location = new System.Drawing.Point(5, 112);
            this.startingGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingGainLabel.Name = "startingGainLabel";
            this.startingGainLabel.Size = new System.Drawing.Size(134, 36);
            this.startingGainLabel.TabIndex = 13;
            this.startingGainLabel.Text = "Starting Gain:";
            this.startingGainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingFrequencyDataLabel
            // 
            this.startingFrequencyDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingFrequencyDataLabel.AutoSize = true;
            this.startingFrequencyDataLabel.Location = new System.Drawing.Point(286, 158);
            this.startingFrequencyDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingFrequencyDataLabel.Name = "startingFrequencyDataLabel";
            this.startingFrequencyDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startingFrequencyDataLabel.TabIndex = 14;
            this.startingFrequencyDataLabel.Text = " ";
            this.startingFrequencyDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingFrequencyLabel
            // 
            this.startingFrequencyLabel.AutoSize = true;
            this.startingFrequencyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingFrequencyLabel.Location = new System.Drawing.Point(5, 149);
            this.startingFrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingFrequencyLabel.Name = "startingFrequencyLabel";
            this.startingFrequencyLabel.Size = new System.Drawing.Size(179, 36);
            this.startingFrequencyLabel.TabIndex = 15;
            this.startingFrequencyLabel.Text = "Starting Frequency:";
            this.startingFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingGainDataLabel
            // 
            this.endingGainDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingGainDataLabel.AutoSize = true;
            this.endingGainDataLabel.Location = new System.Drawing.Point(286, 195);
            this.endingGainDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingGainDataLabel.Name = "endingGainDataLabel";
            this.endingGainDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endingGainDataLabel.TabIndex = 16;
            this.endingGainDataLabel.Text = " ";
            this.endingGainDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingGainLabel
            // 
            this.endingGainLabel.AutoSize = true;
            this.endingGainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingGainLabel.Location = new System.Drawing.Point(5, 186);
            this.endingGainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingGainLabel.Name = "endingGainLabel";
            this.endingGainLabel.Size = new System.Drawing.Size(116, 36);
            this.endingGainLabel.TabIndex = 17;
            this.endingGainLabel.Text = "Ending Gain:";
            this.endingGainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingFrequencyDataLabel
            // 
            this.endingFrequencyDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingFrequencyDataLabel.AutoSize = true;
            this.endingFrequencyDataLabel.Location = new System.Drawing.Point(286, 232);
            this.endingFrequencyDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingFrequencyDataLabel.Name = "endingFrequencyDataLabel";
            this.endingFrequencyDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endingFrequencyDataLabel.TabIndex = 18;
            this.endingFrequencyDataLabel.Text = " ";
            this.endingFrequencyDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingFrequencyLabel
            // 
            this.endingFrequencyLabel.AutoSize = true;
            this.endingFrequencyLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingFrequencyLabel.Location = new System.Drawing.Point(5, 223);
            this.endingFrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingFrequencyLabel.Name = "endingFrequencyLabel";
            this.endingFrequencyLabel.Size = new System.Drawing.Size(161, 36);
            this.endingFrequencyLabel.TabIndex = 19;
            this.endingFrequencyLabel.Text = "Ending Frequency:";
            this.endingFrequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTactorLocationLabel
            // 
            this.startTactorLocationLabel.AutoSize = true;
            this.startTactorLocationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startTactorLocationLabel.Location = new System.Drawing.Point(5, 260);
            this.startTactorLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTactorLocationLabel.Name = "startTactorLocationLabel";
            this.startTactorLocationLabel.Size = new System.Drawing.Size(206, 36);
            this.startTactorLocationLabel.TabIndex = 20;
            this.startTactorLocationLabel.Text = "Start Tactor Location:";
            this.startTactorLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTactorLocationDataLabel
            // 
            this.startTactorLocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTactorLocationDataLabel.AutoSize = true;
            this.startTactorLocationDataLabel.Location = new System.Drawing.Point(286, 269);
            this.startTactorLocationDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTactorLocationDataLabel.Name = "startTactorLocationDataLabel";
            this.startTactorLocationDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startTactorLocationDataLabel.TabIndex = 21;
            this.startTactorLocationDataLabel.Text = " ";
            this.startTactorLocationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTactorLocationDataLabel
            // 
            this.endTactorLocationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTactorLocationDataLabel.AutoSize = true;
            this.endTactorLocationDataLabel.Location = new System.Drawing.Point(286, 306);
            this.endTactorLocationDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endTactorLocationDataLabel.Name = "endTactorLocationDataLabel";
            this.endTactorLocationDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endTactorLocationDataLabel.TabIndex = 22;
            this.endTactorLocationDataLabel.Text = " ";
            this.endTactorLocationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTactorLocationLabel
            // 
            this.endTactorLocationLabel.AutoSize = true;
            this.endTactorLocationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endTactorLocationLabel.Location = new System.Drawing.Point(5, 297);
            this.endTactorLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endTactorLocationLabel.Name = "endTactorLocationLabel";
            this.endTactorLocationLabel.Size = new System.Drawing.Size(188, 36);
            this.endTactorLocationLabel.TabIndex = 23;
            this.endTactorLocationLabel.Text = "End Tactor Location:";
            this.endTactorLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingISIDataLabel
            // 
            this.startingISIDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingISIDataLabel.AutoSize = true;
            this.startingISIDataLabel.Location = new System.Drawing.Point(286, 343);
            this.startingISIDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingISIDataLabel.Name = "startingISIDataLabel";
            this.startingISIDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startingISIDataLabel.TabIndex = 24;
            this.startingISIDataLabel.Text = " ";
            this.startingISIDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingISILabel
            // 
            this.startingISILabel.AutoSize = true;
            this.startingISILabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingISILabel.Location = new System.Drawing.Point(5, 334);
            this.startingISILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingISILabel.Name = "startingISILabel";
            this.startingISILabel.Size = new System.Drawing.Size(125, 36);
            this.startingISILabel.TabIndex = 25;
            this.startingISILabel.Text = "Starting ISI:";
            this.startingISILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingISIDataLabel
            // 
            this.endingISIDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingISIDataLabel.AutoSize = true;
            this.endingISIDataLabel.Location = new System.Drawing.Point(286, 380);
            this.endingISIDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingISIDataLabel.Name = "endingISIDataLabel";
            this.endingISIDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endingISIDataLabel.TabIndex = 26;
            this.endingISIDataLabel.Text = " ";
            this.endingISIDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingISILabel
            // 
            this.endingISILabel.AutoSize = true;
            this.endingISILabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingISILabel.Location = new System.Drawing.Point(5, 371);
            this.endingISILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingISILabel.Name = "endingISILabel";
            this.endingISILabel.Size = new System.Drawing.Size(107, 36);
            this.endingISILabel.TabIndex = 27;
            this.endingISILabel.Text = "Ending ISI:";
            this.endingISILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPulseDurationDataLabel
            // 
            this.startingPulseDurationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startingPulseDurationDataLabel.AutoSize = true;
            this.startingPulseDurationDataLabel.Location = new System.Drawing.Point(286, 417);
            this.startingPulseDurationDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingPulseDurationDataLabel.Name = "startingPulseDurationDataLabel";
            this.startingPulseDurationDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startingPulseDurationDataLabel.TabIndex = 28;
            this.startingPulseDurationDataLabel.Text = " ";
            this.startingPulseDurationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPulseDurationLabel
            // 
            this.startingPulseDurationLabel.AutoSize = true;
            this.startingPulseDurationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startingPulseDurationLabel.Location = new System.Drawing.Point(5, 408);
            this.startingPulseDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startingPulseDurationLabel.Name = "startingPulseDurationLabel";
            this.startingPulseDurationLabel.Size = new System.Drawing.Size(134, 36);
            this.startingPulseDurationLabel.TabIndex = 29;
            this.startingPulseDurationLabel.Text = "Starting Pulse Duration:";
            this.startingPulseDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingPulseDurationDataLabel
            // 
            this.endingPulseDurationDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endingPulseDurationDataLabel.AutoSize = true;
            this.endingPulseDurationDataLabel.Location = new System.Drawing.Point(286, 454);
            this.endingPulseDurationDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingPulseDurationDataLabel.Name = "endingPulseDurationDataLabel";
            this.endingPulseDurationDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endingPulseDurationDataLabel.TabIndex = 30;
            this.endingPulseDurationDataLabel.Text = " ";
            this.endingPulseDurationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endingPulseDurationLabel
            // 
            this.endingPulseDurationLabel.AutoSize = true;
            this.endingPulseDurationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.endingPulseDurationLabel.Location = new System.Drawing.Point(5, 445);
            this.endingPulseDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endingPulseDurationLabel.Name = "endingPulseDurationLabel";
            this.endingPulseDurationLabel.Size = new System.Drawing.Size(206, 36);
            this.endingPulseDurationLabel.TabIndex = 31;
            this.endingPulseDurationLabel.Text = "Ending Pulse Duration:";
            this.endingPulseDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startChangeAfterPulseNumberDataLabel
            // 
            this.startChangeAfterPulseNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startChangeAfterPulseNumberDataLabel.AutoSize = true;
            this.startChangeAfterPulseNumberDataLabel.Location = new System.Drawing.Point(286, 491);
            this.startChangeAfterPulseNumberDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startChangeAfterPulseNumberDataLabel.Name = "startChangeAfterPulseNumberDataLabel";
            this.startChangeAfterPulseNumberDataLabel.Size = new System.Drawing.Size(17, 18);
            this.startChangeAfterPulseNumberDataLabel.TabIndex = 32;
            this.startChangeAfterPulseNumberDataLabel.Text = " ";
            this.startChangeAfterPulseNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startChangeAfterPulseNumberLabel
            // 
            this.startChangeAfterPulseNumberLabel.AutoSize = true;
            this.startChangeAfterPulseNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.startChangeAfterPulseNumberLabel.Location = new System.Drawing.Point(5, 482);
            this.startChangeAfterPulseNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startChangeAfterPulseNumberLabel.Name = "startChangeAfterPulseNumberLabel";
            this.startChangeAfterPulseNumberLabel.Size = new System.Drawing.Size(170, 36);
            this.startChangeAfterPulseNumberLabel.TabIndex = 33;
            this.startChangeAfterPulseNumberLabel.Text = "Start Change After Pulse #:";
            this.startChangeAfterPulseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.1626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.8374F));
            this.tableLayoutPanel1.Controls.Add(this.EndChangeAfterPulseNumberLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.endChangeAfterPulseNumberDataLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.startChangeAfterPulseNumberLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.startChangeAfterPulseNumberDataLabel, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.endingPulseDurationLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.endingPulseDurationDataLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.startingPulseDurationLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.startingPulseDurationDataLabel, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.endingISILabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.endingISIDataLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.startingISILabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.startingISIDataLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.endTactorLocationLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.endTactorLocationDataLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.startTactorLocationDataLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.startTactorLocationLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.endingFrequencyLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.endingFrequencyDataLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.endingGainLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.endingGainDataLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.startingFrequencyLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startingFrequencyDataLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startingGainLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.startingGainDataLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TypeofchangeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.typeOfChangeDataLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cueNumberForInputLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cueNumberForInputDataLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newscreenNumberLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newScreenNumberDataLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(416, 77);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 557);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // DeltaTimeLable
            // 
            this.DeltaTimeLable.AutoSize = true;
            this.DeltaTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaTimeLable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeltaTimeLable.Location = new System.Drawing.Point(699, 44);
            this.DeltaTimeLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeltaTimeLable.Name = "DeltaTimeLable";
            this.DeltaTimeLable.Size = new System.Drawing.Size(103, 29);
            this.DeltaTimeLable.TabIndex = 15;
            this.DeltaTimeLable.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Will be presented in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Next Cue";
            // 
            // NextCueButton
            // 
            this.NextCueButton.Enabled = false;
            this.NextCueButton.Location = new System.Drawing.Point(199, 124);
            this.NextCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextCueButton.Name = "NextCueButton";
            this.NextCueButton.Size = new System.Drawing.Size(161, 61);
            this.NextCueButton.TabIndex = 5;
            this.NextCueButton.Text = "Next Cue";
            this.NextCueButton.UseVisualStyleBackColor = true;
            this.NextCueButton.Click += new System.EventHandler(this.NextCueButton_Click);
            // 
            // btnIntenseMatch
            // 
            this.btnIntenseMatch.Location = new System.Drawing.Point(653, 640);
            this.btnIntenseMatch.Name = "btnIntenseMatch";
            this.btnIntenseMatch.Size = new System.Drawing.Size(192, 28);
            this.btnIntenseMatch.TabIndex = 16;
            this.btnIntenseMatch.Text = "Intensity Matching";
            this.btnIntenseMatch.UseVisualStyleBackColor = true;
            this.btnIntenseMatch.Click += new System.EventHandler(this.btnIntenseMatch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tactorNumLabel
            // 
            this.tactorNumLabel.AutoSize = true;
            this.tactorNumLabel.Location = new System.Drawing.Point(3, 0);
            this.tactorNumLabel.Name = "tactorNumLabel";
            this.tactorNumLabel.Size = new System.Drawing.Size(152, 18);
            this.tactorNumLabel.TabIndex = 18;
            this.tactorNumLabel.Text = "Number of tactor";
            // 
            // TactorNumDataLabel
            // 
            this.TactorNumDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TactorNumDataLabel.AutoSize = true;
            this.TactorNumDataLabel.Location = new System.Drawing.Point(277, 20);
            this.TactorNumDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TactorNumDataLabel.Name = "TactorNumDataLabel";
            this.TactorNumDataLabel.Size = new System.Drawing.Size(17, 18);
            this.TactorNumDataLabel.TabIndex = 35;
            this.TactorNumDataLabel.Text = " ";
            this.TactorNumDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.23077F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel2.Controls.Add(this.TransientTimingDataLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TransientTypeDataLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ISILengthDataLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ISILengthLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TactorNumDataLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tactorNumLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TransientTypeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TransientTimingLabel, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 401);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 233);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // endChangeAfterPulseNumberDataLabel
            // 
            this.endChangeAfterPulseNumberDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endChangeAfterPulseNumberDataLabel.AutoSize = true;
            this.endChangeAfterPulseNumberDataLabel.Location = new System.Drawing.Point(286, 528);
            this.endChangeAfterPulseNumberDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endChangeAfterPulseNumberDataLabel.Name = "endChangeAfterPulseNumberDataLabel";
            this.endChangeAfterPulseNumberDataLabel.Size = new System.Drawing.Size(17, 18);
            this.endChangeAfterPulseNumberDataLabel.TabIndex = 34;
            this.endChangeAfterPulseNumberDataLabel.Text = " ";
            this.endChangeAfterPulseNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndChangeAfterPulseNumberLabel
            // 
            this.EndChangeAfterPulseNumberLabel.AutoSize = true;
            this.EndChangeAfterPulseNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.EndChangeAfterPulseNumberLabel.Location = new System.Drawing.Point(5, 519);
            this.EndChangeAfterPulseNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndChangeAfterPulseNumberLabel.Name = "EndChangeAfterPulseNumberLabel";
            this.EndChangeAfterPulseNumberLabel.Size = new System.Drawing.Size(206, 37);
            this.EndChangeAfterPulseNumberLabel.TabIndex = 35;
            this.EndChangeAfterPulseNumberLabel.Text = "End Change After Label #:";
            this.EndChangeAfterPulseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ISILengthLabel
            // 
            this.ISILengthLabel.AutoSize = true;
            this.ISILengthLabel.Location = new System.Drawing.Point(3, 58);
            this.ISILengthLabel.Name = "ISILengthLabel";
            this.ISILengthLabel.Size = new System.Drawing.Size(98, 18);
            this.ISILengthLabel.TabIndex = 36;
            this.ISILengthLabel.Text = "ISI Length";
            // 
            // TransientTypeLabel
            // 
            this.TransientTypeLabel.AutoSize = true;
            this.TransientTypeLabel.Location = new System.Drawing.Point(3, 116);
            this.TransientTypeLabel.Name = "TransientTypeLabel";
            this.TransientTypeLabel.Size = new System.Drawing.Size(134, 18);
            this.TransientTypeLabel.TabIndex = 37;
            this.TransientTypeLabel.Text = "Transient Type";
            // 
            // TransientTimingLabel
            // 
            this.TransientTimingLabel.AutoSize = true;
            this.TransientTimingLabel.Location = new System.Drawing.Point(3, 174);
            this.TransientTimingLabel.Name = "TransientTimingLabel";
            this.TransientTimingLabel.Size = new System.Drawing.Size(152, 18);
            this.TransientTimingLabel.TabIndex = 38;
            this.TransientTimingLabel.Text = "Transient Timing";
            // 
            // ISILengthDataLabel
            // 
            this.ISILengthDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ISILengthDataLabel.AutoSize = true;
            this.ISILengthDataLabel.Location = new System.Drawing.Point(277, 78);
            this.ISILengthDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISILengthDataLabel.Name = "ISILengthDataLabel";
            this.ISILengthDataLabel.Size = new System.Drawing.Size(17, 18);
            this.ISILengthDataLabel.TabIndex = 39;
            this.ISILengthDataLabel.Text = " ";
            this.ISILengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransientTypeDataLabel
            // 
            this.TransientTypeDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransientTypeDataLabel.AutoSize = true;
            this.TransientTypeDataLabel.Location = new System.Drawing.Point(277, 136);
            this.TransientTypeDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransientTypeDataLabel.Name = "TransientTypeDataLabel";
            this.TransientTypeDataLabel.Size = new System.Drawing.Size(17, 18);
            this.TransientTypeDataLabel.TabIndex = 40;
            this.TransientTypeDataLabel.Text = " ";
            this.TransientTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransientTimingDataLabel
            // 
            this.TransientTimingDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransientTimingDataLabel.AutoSize = true;
            this.TransientTimingDataLabel.Location = new System.Drawing.Point(277, 194);
            this.TransientTimingDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransientTimingDataLabel.Name = "TransientTimingDataLabel";
            this.TransientTimingDataLabel.Size = new System.Drawing.Size(17, 18);
            this.TransientTimingDataLabel.TabIndex = 41;
            this.TransientTimingDataLabel.Text = " ";
            this.TransientTimingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TCSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 673);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIntenseMatch);
            this.Controls.Add(this.DeltaTimeLable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.playCueButton);
            this.Controls.Add(this.selectCueNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsoleOutputRichTextBox);
            this.Controls.Add(this.NextCueButton);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DiscoverButton);
            this.Controls.Add(this.ComPortLabel);
            this.Controls.Add(this.ComPortComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCSForm";
            this.Text = "Tactile Cues Sim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCS_FormClosed);
            this.Load += new System.EventHandler(this.TCSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectCueNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Button DiscoverButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.RichTextBox ConsoleOutputRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectCueNumericUpDown;
        private System.Windows.Forms.Button playCueButton;
        private System.Windows.Forms.Label newScreenNumberDataLabel;
        private System.Windows.Forms.Label newscreenNumberLabel;
        private System.Windows.Forms.Label cueNumberForInputDataLabel;
        private System.Windows.Forms.Label cueNumberForInputLabel;
        private System.Windows.Forms.Label typeOfChangeDataLabel;
        private System.Windows.Forms.Label TypeofchangeLabel;
        private System.Windows.Forms.Label startingGainDataLabel;
        private System.Windows.Forms.Label startingGainLabel;
        private System.Windows.Forms.Label startingFrequencyDataLabel;
        private System.Windows.Forms.Label startingFrequencyLabel;
        private System.Windows.Forms.Label endingGainDataLabel;
        private System.Windows.Forms.Label endingGainLabel;
        private System.Windows.Forms.Label endingFrequencyDataLabel;
        private System.Windows.Forms.Label endingFrequencyLabel;
        private System.Windows.Forms.Label startTactorLocationLabel;
        private System.Windows.Forms.Label startTactorLocationDataLabel;
        private System.Windows.Forms.Label endTactorLocationDataLabel;
        private System.Windows.Forms.Label endTactorLocationLabel;
        private System.Windows.Forms.Label startingISIDataLabel;
        private System.Windows.Forms.Label startingISILabel;
        private System.Windows.Forms.Label endingISIDataLabel;
        private System.Windows.Forms.Label endingISILabel;
        private System.Windows.Forms.Label startingPulseDurationDataLabel;
        private System.Windows.Forms.Label startingPulseDurationLabel;
        private System.Windows.Forms.Label endingPulseDurationDataLabel;
        private System.Windows.Forms.Label endingPulseDurationLabel;
        private System.Windows.Forms.Label startChangeAfterPulseNumberDataLabel;
        private System.Windows.Forms.Label startChangeAfterPulseNumberLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DeltaTimeLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextCueButton;
        private System.Windows.Forms.Button btnIntenseMatch;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label tactorNumLabel;
        private System.Windows.Forms.Label TactorNumDataLabel;
        private System.Windows.Forms.Label EndChangeAfterPulseNumberLabel;
        private System.Windows.Forms.Label endChangeAfterPulseNumberDataLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TransientTimingDataLabel;
        private System.Windows.Forms.Label TransientTypeDataLabel;
        private System.Windows.Forms.Label ISILengthDataLabel;
        private System.Windows.Forms.Label ISILengthLabel;
        private System.Windows.Forms.Label TransientTypeLabel;
        private System.Windows.Forms.Label TransientTimingLabel;
    }
}

