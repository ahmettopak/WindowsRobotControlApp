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
            this.shoulderButton = new System.Windows.Forms.Button();
            this.elbowButton = new System.Windows.Forms.Button();
            this.turretButton = new System.Windows.Forms.Button();
            this.clampButton = new System.Windows.Forms.Button();
            this.ptzButton = new System.Windows.Forms.Button();
            this.wristButton = new System.Windows.Forms.Button();
            this.lightMenu = new System.Windows.Forms.Panel();
            this.ptzLightLabel = new System.Windows.Forms.Label();
            this.ptzLightTrackBar = new System.Windows.Forms.TrackBar();
            this.aimLightButton = new System.Windows.Forms.Button();
            this.armLightButton = new System.Windows.Forms.Button();
            this.backLightButton = new System.Windows.Forms.Button();
            this.frontLightButton = new System.Windows.Forms.Button();
            this.openLightMenuButton = new System.Windows.Forms.Button();
            this.leftVideoPanel.SuspendLayout();
            this.rightVideoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.lightMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptzLightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // leftVideoPanel
            // 
            this.leftVideoPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.leftVideoPanel.Controls.Add(this.leftFullSizeButton);
            this.leftVideoPanel.Controls.Add(this.leftCameraComboBox);
            this.leftVideoPanel.Location = new System.Drawing.Point(9, 83);
            this.leftVideoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftVideoPanel.Name = "leftVideoPanel";
            this.leftVideoPanel.Size = new System.Drawing.Size(940, 640);
            this.leftVideoPanel.TabIndex = 1;
            // 
            // leftFullSizeButton
            // 
            this.leftFullSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.leftFullSizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftFullSizeButton.BackgroundImage")));
            this.leftFullSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftFullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftFullSizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.leftFullSizeButton.Location = new System.Drawing.Point(102, 2);
            this.leftFullSizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.leftFullSizeButton.Name = "leftFullSizeButton";
            this.leftFullSizeButton.Size = new System.Drawing.Size(38, 41);
            this.leftFullSizeButton.TabIndex = 1;
            this.leftFullSizeButton.UseVisualStyleBackColor = false;
            this.leftFullSizeButton.Click += new System.EventHandler(this.leftFullSizeButton_Click);
            // 
            // leftCameraComboBox
            // 
            this.leftCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leftCameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftCameraComboBox.FormattingEnabled = true;
            this.leftCameraComboBox.Location = new System.Drawing.Point(2, 2);
            this.leftCameraComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.leftCameraComboBox.Name = "leftCameraComboBox";
            this.leftCameraComboBox.Size = new System.Drawing.Size(98, 37);
            this.leftCameraComboBox.TabIndex = 0;
            this.leftCameraComboBox.SelectedIndexChanged += new System.EventHandler(this.leftCameraComboBox_SelectedIndexChanged);
            // 
            // rightVideoPanel
            // 
            this.rightVideoPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.rightVideoPanel.Controls.Add(this.rightFullSizeButton);
            this.rightVideoPanel.Controls.Add(this.rightCameraComboBox);
            this.rightVideoPanel.Location = new System.Drawing.Point(953, 83);
            this.rightVideoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightVideoPanel.Name = "rightVideoPanel";
            this.rightVideoPanel.Size = new System.Drawing.Size(940, 640);
            this.rightVideoPanel.TabIndex = 2;
            // 
            // rightFullSizeButton
            // 
            this.rightFullSizeButton.BackColor = System.Drawing.Color.Transparent;
            this.rightFullSizeButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.fullsize_right;
            this.rightFullSizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightFullSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightFullSizeButton.Location = new System.Drawing.Point(800, 2);
            this.rightFullSizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.rightFullSizeButton.Name = "rightFullSizeButton";
            this.rightFullSizeButton.Size = new System.Drawing.Size(38, 41);
            this.rightFullSizeButton.TabIndex = 1;
            this.rightFullSizeButton.UseVisualStyleBackColor = false;
            this.rightFullSizeButton.Click += new System.EventHandler(this.rightFullSizeButton_Click);
            // 
            // rightCameraComboBox
            // 
            this.rightCameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightCameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightCameraComboBox.FormattingEnabled = true;
            this.rightCameraComboBox.Location = new System.Drawing.Point(840, 2);
            this.rightCameraComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.rightCameraComboBox.Name = "rightCameraComboBox";
            this.rightCameraComboBox.Size = new System.Drawing.Size(98, 37);
            this.rightCameraComboBox.TabIndex = 0;
            this.rightCameraComboBox.SelectedIndexChanged += new System.EventHandler(this.rightCameraComboBox_SelectedIndexChanged);
            // 
            // galleryButton
            // 
            this.galleryButton.BackColor = System.Drawing.Color.Transparent;
            this.galleryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.gallery1;
            this.galleryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.galleryButton.Location = new System.Drawing.Point(1752, 13);
            this.galleryButton.Margin = new System.Windows.Forms.Padding(2);
            this.galleryButton.Name = "galleryButton";
            this.galleryButton.Size = new System.Drawing.Size(38, 41);
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
            this.screenShotButton.Location = new System.Drawing.Point(1668, 13);
            this.screenShotButton.Margin = new System.Windows.Forms.Padding(2);
            this.screenShotButton.Name = "screenShotButton";
            this.screenShotButton.Size = new System.Drawing.Size(38, 41);
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
            this.screenRecordButton.Location = new System.Drawing.Point(1710, 13);
            this.screenRecordButton.Margin = new System.Windows.Forms.Padding(2);
            this.screenRecordButton.Name = "screenRecordButton";
            this.screenRecordButton.Size = new System.Drawing.Size(38, 41);
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
            this.refreshButton.Location = new System.Drawing.Point(929, 63);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(38, 41);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsRobotControl.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(767, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 47);
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
            this.videoCapture1.Location = new System.Drawing.Point(1895, 46);
            this.videoCapture1.Margin = new System.Windows.Forms.Padding(2);
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
            this.videoCapture1.Size = new System.Drawing.Size(8, 12);
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
            this.listBox1.Location = new System.Drawing.Point(767, 740);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 290);
            this.listBox1.TabIndex = 7;
            // 
            // robotBatteryButton
            // 
            this.robotBatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.robotBatteryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.robot_battery;
            this.robotBatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.robotBatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.robotBatteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotBatteryButton.ForeColor = System.Drawing.Color.Lime;
            this.robotBatteryButton.Location = new System.Drawing.Point(1794, 10);
            this.robotBatteryButton.Margin = new System.Windows.Forms.Padding(2);
            this.robotBatteryButton.Name = "robotBatteryButton";
            this.robotBatteryButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.robotBatteryButton.Size = new System.Drawing.Size(46, 68);
            this.robotBatteryButton.TabIndex = 8;
            this.robotBatteryButton.Text = "??";
            this.robotBatteryButton.UseVisualStyleBackColor = false;
            // 
            // panelBatteryButton
            // 
            this.panelBatteryButton.BackColor = System.Drawing.Color.Transparent;
            this.panelBatteryButton.BackgroundImage = global::WindowsRobotControl.Properties.Resources.panel_battery;
            this.panelBatteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBatteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.panelBatteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBatteryButton.ForeColor = System.Drawing.Color.Lime;
            this.panelBatteryButton.Location = new System.Drawing.Point(1845, 10);
            this.panelBatteryButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelBatteryButton.Name = "panelBatteryButton";
            this.panelBatteryButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelBatteryButton.Size = new System.Drawing.Size(46, 68);
            this.panelBatteryButton.TabIndex = 9;
            this.panelBatteryButton.Text = "??";
            this.panelBatteryButton.UseVisualStyleBackColor = false;
            // 
            // shoulderButton
            // 
            this.shoulderButton.BackColor = System.Drawing.Color.Lime;
            this.shoulderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shoulderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shoulderButton.ForeColor = System.Drawing.Color.Black;
            this.shoulderButton.Location = new System.Drawing.Point(12, 788);
            this.shoulderButton.Name = "shoulderButton";
            this.shoulderButton.Size = new System.Drawing.Size(151, 49);
            this.shoulderButton.TabIndex = 11;
            this.shoulderButton.Text = "SHOULDER";
            this.shoulderButton.UseVisualStyleBackColor = false;
            this.shoulderButton.Click += new System.EventHandler(this.shoulderButton_Click);
            // 
            // elbowButton
            // 
            this.elbowButton.BackColor = System.Drawing.Color.Lime;
            this.elbowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.elbowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.elbowButton.ForeColor = System.Drawing.Color.Black;
            this.elbowButton.Location = new System.Drawing.Point(12, 850);
            this.elbowButton.Name = "elbowButton";
            this.elbowButton.Size = new System.Drawing.Size(151, 48);
            this.elbowButton.TabIndex = 12;
            this.elbowButton.Text = "ELBOW";
            this.elbowButton.UseVisualStyleBackColor = false;
            this.elbowButton.Click += new System.EventHandler(this.elbowButton_Click);
            // 
            // turretButton
            // 
            this.turretButton.BackColor = System.Drawing.Color.Lime;
            this.turretButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turretButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turretButton.ForeColor = System.Drawing.Color.Black;
            this.turretButton.Location = new System.Drawing.Point(12, 728);
            this.turretButton.Name = "turretButton";
            this.turretButton.Size = new System.Drawing.Size(151, 47);
            this.turretButton.TabIndex = 13;
            this.turretButton.Text = "TURRET";
            this.turretButton.UseVisualStyleBackColor = false;
            this.turretButton.Click += new System.EventHandler(this.turretButton_Click);
            // 
            // clampButton
            // 
            this.clampButton.BackColor = System.Drawing.Color.Lime;
            this.clampButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clampButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clampButton.ForeColor = System.Drawing.Color.Black;
            this.clampButton.Location = new System.Drawing.Point(1756, 788);
            this.clampButton.Name = "clampButton";
            this.clampButton.Size = new System.Drawing.Size(137, 45);
            this.clampButton.TabIndex = 14;
            this.clampButton.Text = "CLAMP";
            this.clampButton.UseVisualStyleBackColor = false;
            this.clampButton.Click += new System.EventHandler(this.clampButton_Click);
            // 
            // ptzButton
            // 
            this.ptzButton.BackColor = System.Drawing.Color.Lime;
            this.ptzButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ptzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ptzButton.ForeColor = System.Drawing.Color.Black;
            this.ptzButton.Location = new System.Drawing.Point(1756, 852);
            this.ptzButton.Name = "ptzButton";
            this.ptzButton.Size = new System.Drawing.Size(137, 43);
            this.ptzButton.TabIndex = 16;
            this.ptzButton.Text = "PTZ";
            this.ptzButton.UseVisualStyleBackColor = false;
            this.ptzButton.Click += new System.EventHandler(this.ptzButton_Click);
            // 
            // wristButton
            // 
            this.wristButton.BackColor = System.Drawing.Color.Lime;
            this.wristButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wristButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wristButton.ForeColor = System.Drawing.Color.Black;
            this.wristButton.Location = new System.Drawing.Point(1756, 729);
            this.wristButton.Name = "wristButton";
            this.wristButton.Size = new System.Drawing.Size(137, 43);
            this.wristButton.TabIndex = 17;
            this.wristButton.Text = "WRIST";
            this.wristButton.UseVisualStyleBackColor = false;
            this.wristButton.Click += new System.EventHandler(this.wristButton_Click);
            // 
            // lightMenu
            // 
            this.lightMenu.BackColor = System.Drawing.Color.Black;
            this.lightMenu.Controls.Add(this.ptzLightLabel);
            this.lightMenu.Controls.Add(this.ptzLightTrackBar);
            this.lightMenu.Controls.Add(this.aimLightButton);
            this.lightMenu.Controls.Add(this.armLightButton);
            this.lightMenu.Controls.Add(this.backLightButton);
            this.lightMenu.Controls.Add(this.frontLightButton);
            this.lightMenu.Location = new System.Drawing.Point(311, 46);
            this.lightMenu.Margin = new System.Windows.Forms.Padding(2);
            this.lightMenu.Name = "lightMenu";
            this.lightMenu.Size = new System.Drawing.Size(112, 205);
            this.lightMenu.TabIndex = 18;
            this.lightMenu.Visible = false;
            // 
            // ptzLightLabel
            // 
            this.ptzLightLabel.AutoSize = true;
            this.ptzLightLabel.Location = new System.Drawing.Point(9, 127);
            this.ptzLightLabel.Name = "ptzLightLabel";
            this.ptzLightLabel.Size = new System.Drawing.Size(28, 13);
            this.ptzLightLabel.TabIndex = 5;
            this.ptzLightLabel.Text = "PTZ";
            // 
            // ptzLightTrackBar
            // 
            this.ptzLightTrackBar.LargeChange = 1;
            this.ptzLightTrackBar.Location = new System.Drawing.Point(2, 143);
            this.ptzLightTrackBar.Maximum = 3;
            this.ptzLightTrackBar.Name = "ptzLightTrackBar";
            this.ptzLightTrackBar.Size = new System.Drawing.Size(104, 45);
            this.ptzLightTrackBar.TabIndex = 4;
            this.ptzLightTrackBar.Scroll += new System.EventHandler(this.ptzLightTrackBar_Scroll);
            // 
            // aimLightButton
            // 
            this.aimLightButton.BackColor = System.Drawing.Color.Lime;
            this.aimLightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aimLightButton.ForeColor = System.Drawing.Color.Black;
            this.aimLightButton.Location = new System.Drawing.Point(2, 92);
            this.aimLightButton.Margin = new System.Windows.Forms.Padding(2);
            this.aimLightButton.Name = "aimLightButton";
            this.aimLightButton.Size = new System.Drawing.Size(107, 26);
            this.aimLightButton.TabIndex = 3;
            this.aimLightButton.Text = "Aim";
            this.aimLightButton.UseVisualStyleBackColor = false;
            this.aimLightButton.Click += new System.EventHandler(this.aimLightButton_Click);
            // 
            // armLightButton
            // 
            this.armLightButton.BackColor = System.Drawing.Color.Lime;
            this.armLightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.armLightButton.ForeColor = System.Drawing.Color.Black;
            this.armLightButton.Location = new System.Drawing.Point(2, 64);
            this.armLightButton.Margin = new System.Windows.Forms.Padding(2);
            this.armLightButton.Name = "armLightButton";
            this.armLightButton.Size = new System.Drawing.Size(107, 26);
            this.armLightButton.TabIndex = 2;
            this.armLightButton.Text = "arm";
            this.armLightButton.UseVisualStyleBackColor = false;
            this.armLightButton.Click += new System.EventHandler(this.armLightButton_Click);
            // 
            // backLightButton
            // 
            this.backLightButton.BackColor = System.Drawing.Color.Lime;
            this.backLightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backLightButton.ForeColor = System.Drawing.Color.Black;
            this.backLightButton.Location = new System.Drawing.Point(2, 36);
            this.backLightButton.Margin = new System.Windows.Forms.Padding(2);
            this.backLightButton.Name = "backLightButton";
            this.backLightButton.Size = new System.Drawing.Size(107, 26);
            this.backLightButton.TabIndex = 1;
            this.backLightButton.Text = "Back";
            this.backLightButton.UseVisualStyleBackColor = false;
            this.backLightButton.Click += new System.EventHandler(this.backLightButton_Click);
            // 
            // frontLightButton
            // 
            this.frontLightButton.BackColor = System.Drawing.Color.Lime;
            this.frontLightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frontLightButton.ForeColor = System.Drawing.Color.Black;
            this.frontLightButton.Location = new System.Drawing.Point(2, 8);
            this.frontLightButton.Margin = new System.Windows.Forms.Padding(2);
            this.frontLightButton.Name = "frontLightButton";
            this.frontLightButton.Size = new System.Drawing.Size(107, 26);
            this.frontLightButton.TabIndex = 0;
            this.frontLightButton.Text = "Front";
            this.frontLightButton.UseVisualStyleBackColor = false;
            this.frontLightButton.Click += new System.EventHandler(this.frontLightButton_Click);
            // 
            // openLightMenuButton
            // 
            this.openLightMenuButton.BackColor = System.Drawing.Color.Lime;
            this.openLightMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openLightMenuButton.ForeColor = System.Drawing.Color.Black;
            this.openLightMenuButton.Location = new System.Drawing.Point(311, 10);
            this.openLightMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.openLightMenuButton.Name = "openLightMenuButton";
            this.openLightMenuButton.Size = new System.Drawing.Size(112, 32);
            this.openLightMenuButton.TabIndex = 19;
            this.openLightMenuButton.Text = "Lights";
            this.openLightMenuButton.UseVisualStyleBackColor = false;
            this.openLightMenuButton.Click += new System.EventHandler(this.openLightMenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lightMenu);
            this.Controls.Add(this.openLightMenuButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.wristButton);
            this.Controls.Add(this.ptzButton);
            this.Controls.Add(this.clampButton);
            this.Controls.Add(this.turretButton);
            this.Controls.Add(this.elbowButton);
            this.Controls.Add(this.shoulderButton);
            this.Controls.Add(this.panelBatteryButton);
            this.Controls.Add(this.robotBatteryButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.videoCapture1);
            this.Controls.Add(this.galleryButton);
            this.Controls.Add(this.screenShotButton);
            this.Controls.Add(this.screenRecordButton);
            this.Controls.Add(this.rightVideoPanel);
            this.Controls.Add(this.leftVideoPanel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Control App";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click_1);
            this.leftVideoPanel.ResumeLayout(false);
            this.rightVideoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.lightMenu.ResumeLayout(false);
            this.lightMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptzLightTrackBar)).EndInit();
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
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button robotBatteryButton;
        public System.Windows.Forms.Button panelBatteryButton;
        private System.Windows.Forms.Button shoulderButton;
        private System.Windows.Forms.Button elbowButton;
        private System.Windows.Forms.Button turretButton;
        private System.Windows.Forms.Button clampButton;
        private System.Windows.Forms.Button ptzButton;
        private System.Windows.Forms.Button wristButton;
        private System.Windows.Forms.Panel lightMenu;
        private System.Windows.Forms.Button aimLightButton;
        private System.Windows.Forms.Button armLightButton;
        private System.Windows.Forms.Button backLightButton;
        private System.Windows.Forms.Button frontLightButton;
        private System.Windows.Forms.Button openLightMenuButton;
        private System.Windows.Forms.Label ptzLightLabel;
        private System.Windows.Forms.TrackBar ptzLightTrackBar;
    }
}

