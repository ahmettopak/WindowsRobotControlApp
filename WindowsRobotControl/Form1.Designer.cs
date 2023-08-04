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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftVideoPanel = new System.Windows.Forms.Panel();
            this.leftFullSizeButton = new System.Windows.Forms.Button();
            this.leftCameraComboBox = new System.Windows.Forms.ComboBox();
            this.rightVideoPanel = new System.Windows.Forms.Panel();
            this.rightFullSizeButton = new System.Windows.Forms.Button();
            this.rightCameraComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftVideoPanel.SuspendLayout();
            this.rightVideoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsRobotControl.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(831, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(2382, 1303);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftVideoPanel.ResumeLayout(false);
            this.rightVideoPanel.ResumeLayout(false);
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
    }
}

