namespace WindowsRobotControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftVideoPanel = new System.Windows.Forms.Panel();
            this.leftFullSizeButton = new System.Windows.Forms.Button();
            this.leftCameraComboBox = new System.Windows.Forms.ComboBox();
            this.rightVideoPanel = new System.Windows.Forms.Panel();
            this.rightFullSizeButton = new System.Windows.Forms.Button();
            this.rightCameraComboBox = new System.Windows.Forms.ComboBox();
            this.galleryButton = new System.Windows.Forms.Button();
            this.screenShotButton = new System.Windows.Forms.Button();
            this.screenRecordButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.robotBatteryButton = new System.Windows.Forms.Button();
            this.panelBatteryButton = new System.Windows.Forms.Button();
            this.leftVideoPanel.SuspendLayout();
            this.rightVideoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftVideoPanel
            // 
            this.leftVideoPanel.Controls.Add(this.leftFullSizeButton);
            this.leftVideoPanel.Controls.Add(this.leftCameraComboBox);
            this.leftVideoPanel.Location = new System.Drawing.Point(12, 99);
            this.leftVideoPanel.Name = "leftVideoPanel";
            this.leftVideoPanel.Size = new System.Drawing.Size(1000, 558);
            this.leftVideoPanel.TabIndex = 1;
            // 
            // leftFullSizeButton
            // 
            this.leftFullSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.leftFullSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftFullSizeButton.BackgroundImage")));
            this.leftFullSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftFullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftFullSizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.leftFullSizeButton.Location = new System.Drawing.Point(136, 3);
            this.leftFullSizeButton.Name = "leftFullSizeButton";
            this.leftFullSizeButton.Size = new System.Drawing.Size(50, 50);
            this.leftFullSizeButton.TabIndex = 1;
            this.leftFullSizeButton.UseVisualStyleBackColor = false;
            this.leftFullSizeButton.Click += new System.EventHandler(this.leftFullSizeButton_Click);
            // 
            // leftCameraComboBox
            // 
            this.leftCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftCameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftCameraComboBox.FormattingEnabled = true;
            this.leftCameraComboBox.Location = new System.Drawing.Point(3, 3);
            this.leftCameraComboBox.Name = "leftCameraComboBox";
            this.leftCameraComboBox.Size = new System.Drawing.Size(130, 44);
            this.leftCameraComboBox.TabIndex = 0;
            this.leftCameraComboBox.SelectedIndexChanged += new System.EventHandler(this.leftCameraComboBox_SelectedIndexChanged);
            // 
            // rightVideoPanel
            // 
            this.rightVideoPanel.Controls.Add(this.rightFullSizeButton);
            this.rightVideoPanel.Controls.Add(this.rightCameraComboBox);
            this.rightVideoPanel.Location = new System.Drawing.Point(1025, 99);
            this.rightVideoPanel.Name = "rightVideoPanel";
            this.rightVideoPanel.Size = new System.Drawing.Size(1000, 558);
            this.rightVideoPanel.TabIndex = 2;
            // 
            // rightFullSizeButton
            // 
            this.rightFullSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.rightFullSizeButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.fullsize_right;
            this.rightFullSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightFullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightFullSizeButton.Location = new System.Drawing.Point(814, 3);
            this.rightFullSizeButton.Name = "rightFullSizeButton";
            this.rightFullSizeButton.Size = new System.Drawing.Size(50, 50);
            this.rightFullSizeButton.TabIndex = 1;
            this.rightFullSizeButton.UseVisualStyleBackColor = false;
            this.rightFullSizeButton.Click += new System.EventHandler(this.rightFullSizeButton_Click);
            // 
            // rightCameraComboBox
            // 
            this.rightCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightCameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightCameraComboBox.FormattingEnabled = true;
            this.rightCameraComboBox.Location = new System.Drawing.Point(867, 3);
            this.rightCameraComboBox.Name = "rightCameraComboBox";
            this.rightCameraComboBox.Size = new System.Drawing.Size(130, 44);
            this.rightCameraComboBox.TabIndex = 0;
            this.rightCameraComboBox.SelectedIndexChanged += new System.EventHandler(this.rightCameraComboBox_SelectedIndexChanged);
            // 
            // galleryButton
            // 
            this.galleryButton.BackColor = System.Drawing.Color.Transparent;
            this.galleryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.gallery1;
            this.galleryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.galleryButton.Location = new System.Drawing.Point(1788, 12);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(50, 50);
            this.galleryButton.TabIndex = 5;
            this.galleryButton.UseVisualStyleBackColor = false;
            this.galleryButton.Click += new System.EventHandler(this.galleryButton_Click);
            // 
            // screenShotButton
            // 
            this.screenShotButton.BackColor = System.Drawing.Color.Transparent;
            this.screenShotButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.capture1;
            this.screenShotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenShotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screenShotButton.Location = new System.Drawing.Point(1676, 12);
            this.screenShotButton.Name = "screenShotButton";
            this.screenShotButton.Size = new System.Drawing.Size(50, 50);
            this.screenShotButton.TabIndex = 4;
            this.screenShotButton.UseVisualStyleBackColor = false;
            this.screenShotButton.Click += new System.EventHandler(this.screenShotButton_Click);
            // 
            // screenRecordButton
            // 
            this.screenRecordButton.BackColor = System.Drawing.Color.Transparent;
            this.screenRecordButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.screen_record;
            this.screenRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screenRecordButton.Location = new System.Drawing.Point(1732, 12);
            this.screenRecordButton.Name = "screenRecordButton";
            this.screenRecordButton.Size = new System.Drawing.Size(50, 50);
            this.screenRecordButton.TabIndex = 2;
            this.screenRecordButton.UseVisualStyleBackColor = false;
            this.screenRecordButton.Click += new System.EventHandler(this.screenRecordButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.refreshButton.Location = new System.Drawing.Point(991, 102);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(50, 50);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsRobotControl.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(790, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture1.Audio_CaptureDevice_Path = null;
            this.videoCapture1.Audio_CaptureSourceFilter = null;
            this.videoCapture1.Audio_Channel_Mapper = null;
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PCM_Converter = null;
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.BDA_Source = null;
            this.videoCapture1.ChromaKey = null;
            this.videoCapture1.Custom_Source = null;
            this.videoCapture1.CustomRedist_Auto = true;
            this.videoCapture1.CustomRedist_DisableDialog = false;
            this.videoCapture1.CustomRedist_Path = null;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_DisableMessageDialogs = false;
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Debug_Telemetry = true;
            this.videoCapture1.Decklink_Input = VisioForge.Types.Decklink.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.Decklink.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.Decklink_Output = null;
            this.videoCapture1.Decklink_Source = null;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Face_Tracking = null;
            this.videoCapture1.IP_Camera_Source = null;
            this.videoCapture1.Location = new System.Drawing.Point(1260, 37);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture1.Motion_Detection = null;
            this.videoCapture1.Motion_DetectionEx = null;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Demuxer = null;
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_Output = null;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.OSD_Enabled = false;
            this.videoCapture1.Output_Filename = "output.mp4";
            this.videoCapture1.Output_Format = null;
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_ChromaKeySettings = null;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture1.Push_Source = null;
            this.videoCapture1.Screen_Capture_Source = null;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_GMFMode = true;
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture1.Size = new System.Drawing.Size(10, 15);
            this.videoCapture1.Start_DelayEnabled = false;
            this.videoCapture1.StatusOverlay = null;
            this.videoCapture1.TabIndex = 6;
            this.videoCapture1.Tags = null;
            this.videoCapture1.Timeshift_Settings = null;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_CustomPinName = null;
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture1.Video_Crop = null;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_Effects_GPU_Enabled = false;
            this.videoCapture1.Video_Effects_MergeImageLogos = false;
            this.videoCapture1.Video_Effects_MergeTextLogos = false;
            this.videoCapture1.Video_Resize = null;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = true;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.Visible = false;
            this.videoCapture1.VLC_Path = null;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(499, 663);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(997, 356);
            this.listBox1.TabIndex = 7;
            // 
            // robotBatteryButton
            // 
            this.robotBatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.robotBatteryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.robot_battery;
            this.robotBatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.robotBatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.robotBatteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotBatteryButton.ForeColor = System.Drawing.Color.Lime;
            this.robotBatteryButton.Location = new System.Drawing.Point(1844, 9);
            this.robotBatteryButton.Name = "robotBatteryButton";
            this.robotBatteryButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.robotBatteryButton.Size = new System.Drawing.Size(62, 84);
            this.robotBatteryButton.TabIndex = 8;
            this.robotBatteryButton.Text = "%100";
            this.robotBatteryButton.UseVisualStyleBackColor = false;
            // 
            // panelBatteryButton
            // 
            this.panelBatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.panelBatteryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.panel_battery;
            this.panelBatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.panelBatteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBatteryButton.ForeColor = System.Drawing.Color.Lime;
            this.panelBatteryButton.Location = new System.Drawing.Point(1912, 9);
            this.panelBatteryButton.Name = "panelBatteryButton";
            this.panelBatteryButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.panelBatteryButton.Size = new System.Drawing.Size(62, 84);
            this.panelBatteryButton.TabIndex = 9;
            this.panelBatteryButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panelBatteryButton);
            this.Controls.Add(this.robotBatteryButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.videoCapture1);
            this.Controls.Add(this.galleryButton);
            this.Controls.Add(this.screenShotButton);
            this.Controls.Add(this.screenRecordButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.rightVideoPanel);
            this.Controls.Add(this.leftVideoPanel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Control App";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftVideoPanel.ResumeLayout(false);
            this.rightVideoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftVideoPanel;
        private System.Windows.Forms.Panel rightVideoPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox leftCameraComboBox;
        private System.Windows.Forms.ComboBox rightCameraComboBox;
        private System.Windows.Forms.Button leftFullSizeButton;
        private System.Windows.Forms.Button rightFullSizeButton;
        private System.Windows.Forms.Button screenRecordButton;
        private System.Windows.Forms.Button screenShotButton;
        private System.Windows.Forms.Button galleryButton;
        public VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button robotBatteryButton;
        public System.Windows.Forms.Button panelBatteryButton;
    }
}

