using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using WindowsRobotControl.udp;
using WindowsRobotControl.Utils;
using static  System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Button = System.Windows.Forms.Button;

namespace WindowsRobotControl
{
    public partial class Form1 : Form
    {
        //Arm button
        private bool isTurret = false;
        private bool isShoulder = false;
        private bool isElbow = false;
        private bool isClamp = false;
        private bool isPtz = false;
        private bool isParkMode = false;
        private bool isWrist = false;

        //Lights
        private bool isLightMenu = false;
        private bool isFrontLight = false;
        private bool isBackLight = false;
        private bool isArmLight = false;
        private bool isAimLight = false;



        UdpReceiver udpReceiver;
        
        public Form1()
        {
            InitializeComponent();
            InitializeCameraComboBox();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lightMenu.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeVlcControl();
            

            ScreenUtil = new ScreenUtil(this);
            _ = new ComputerBatteryController(this);
        
            udpReceiver = new UdpReceiver(this);
            udpReceiver.StartListening();

            //InitializeController();
            //SetupControllerTimer();

            //Right Video View Full Size
            //panel1.SendToBack();
            //panel1.Size = this.ClientSize;



           
        }



        #region VlcStream


        private VlcControl vlcControlLeft;
        private VlcControl vlcControlRight;

        private void InitializeVlcControl()
        {
            vlcControlLeft = new VlcControl();
            vlcControlRight = new VlcControl();

            var vlcArgs = new List<string>
    {
        "--no-plugins-cache",
        "--no-video-title-show",
        "--no-snapshot-preview",
        "--file-caching=0",
        "--clock-jitter=0",
        "--network-caching=80",
        "--live-caching=0",
        "--no-overlay",
        "--clock-jitter=0"

    };


            vlcControlLeft.BeginInit();
            vlcControlLeft.VlcMediaplayerOptions = vlcArgs.ToArray();
            vlcControlLeft.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files (x86)\VideoLAN\VLC"); // VLC kütüphane dizini
            vlcControlLeft.EndInit();
            vlcControlLeft.Dock = DockStyle.Fill;
            leftVideoPanel.Controls.Add(vlcControlLeft); // RTSP yayınını göstermek için bir Panel kontrolü ekleyin


            vlcControlRight.BeginInit();
            vlcControlRight.VlcMediaplayerOptions = vlcArgs.ToArray();
            vlcControlRight.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files (x86)\VideoLAN\VLC"); // VLC kütüphane dizini
            vlcControlRight.EndInit();
            vlcControlRight.Dock = DockStyle.Fill;
            rightVideoPanel.Controls.Add(vlcControlRight); // RTSP yayınını göstermek için bir Panel kontrolü ekleyin
        }

        private void StartLeftVideo(string rtspUrl)
        {
            if (vlcControlLeft != null)
            {
                vlcControlLeft.Stop(); // Önceki medya durduruluyor
                vlcControlLeft.Play(new Uri(rtspUrl));
            }


        }

        private void StartRightVideo(string rtspUrl)
        {
            if (vlcControlRight != null)
            {
                vlcControlRight.Stop(); // Önceki medya durduruluyor
                vlcControlRight.Play(new Uri(rtspUrl));
            }
        }

        private void StopCapture()
        {
            if (vlcControlLeft != null)
            {
                vlcControlLeft.Stop();
            }
        }
        #endregion 


        #region Joystick
        private Controller controller;
        private UserIndex playerIndex = UserIndex.One; // Eğer birden fazla controller varsa, uygun playerIndex'i seçin.
        private Timer controllerTimer;
        private void InitializeController()
        {
            try
            {
                controller = new Controller(playerIndex);
                if (!controller.IsConnected)
                {
                    MessageBox.Show("Controller bulunamadı!");
                    return;
                }
                else
                {
                    MessageBox.Show("Bulundu");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Controller başlatılırken bir hata oluştu: " + ex.Message);
            }
        }

        private void ReadControllerInput()
        {
            if (controller == null || !controller.IsConnected)
                return;

            Gamepad gamepadState = controller.GetState().Gamepad;

            // Gamepad verilerini işleyin
            short leftThumbX = gamepadState.LeftThumbX;
            short leftThumbY = gamepadState.LeftThumbY;
            short rightThumbX = gamepadState.RightThumbX;
            short rightThumbY = gamepadState.RightThumbY;
            byte leftTrigger = gamepadState.LeftTrigger;
            byte rightTrigger = gamepadState.RightTrigger;
            bool buttonA = (gamepadState.Buttons & GamepadButtonFlags.A) != 0;
            bool buttonB = (gamepadState.Buttons & GamepadButtonFlags.B) != 0;
            bool buttonX = (gamepadState.Buttons & GamepadButtonFlags.X) != 0;
            bool buttonY = (gamepadState.Buttons & GamepadButtonFlags.Y) != 0;

            // label1.Text = NormalizeAxisValue(leftThumbX)  + " " + NormalizeAxisValue(leftThumbY);
        }



        private void SetupControllerTimer()
        {
            controllerTimer = new Timer();
            controllerTimer.Interval = 100; // 100 ms aralıklarla veri alacak
            controllerTimer.Tick += (sender, e) => ReadControllerInput();
            controllerTimer.Start();
        }

        private float NormalizeAxisValue(short axisValue)
        {
            const float minAxisValue = -32768f;
            const float maxAxisValue = 32767f;

            return (axisValue - minAxisValue) / ((maxAxisValue - minAxisValue) / 2f) - 1f;
        }

        #endregion


        #region Rtsp Stream

        string[] cameraUrl = {
                "rtsp://192.168.1.10:554/user=admin&password=&channel=1&stream=0.sdp?",
                "rtsp://192.168.1.10:554/user=admin&password=&channel=2&stream=0.sdp?",
                "rtsp://192.168.1.10:554/user=admin&password=&channel=3&stream=0.sdp?",
                "rtsp://192.168.1.10:554/user=admin&password=&channel=4&stream=0.sdp?",
                "rtsp://192.168.1.10:554/user=admin&password=&channel=5&stream=0.sdp?"
        };

        private void InitializeCameraComboBox()
        {
            string[] cameraName = { "Ön", "Arka", "Nişan", "Kıskaç", "PTZ" };


            leftCameraComboBox.Items.Clear();
            foreach (string value in cameraName)
            {
                leftCameraComboBox.Items.Add(value);
            }

            rightCameraComboBox.Items.Clear();
            foreach (string value in cameraName)
            {
                rightCameraComboBox.Items.Add(value);
            }
            leftCameraComboBox.SelectedIndex = 0;
            rightCameraComboBox.SelectedIndex = 0;


        }

        private void leftCameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartLeftVideo(cameraUrl[leftCameraComboBox.SelectedIndex]);
        }

        private void rightCameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartRightVideo(cameraUrl[rightCameraComboBox.SelectedIndex]);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            StartLeftVideo(cameraUrl[leftCameraComboBox.SelectedIndex]);
            StartRightVideo(cameraUrl[rightCameraComboBox.SelectedIndex]);
        }

        private void rightFullSizeButton_Click(object sender, EventArgs e)
        {

        }

        private void leftFullSizeButton_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Screen Utils
        ScreenUtil ScreenUtil;
        bool isRecordStart = false;
        private void screenShotButton_Click(object sender, EventArgs e)
        {
            ScreenUtil.checkScreenShot();
        }

        private void galleryButton_Click(object sender, EventArgs e)
        {
            ScreenUtil.openGallery();
        }

        private async void screenRecordButton_Click(object sender, EventArgs e)
        {
            if (isRecordStart)
            {
                await videoCapture1.StopAsync();
                isRecordStart = false;
                screenRecordButton.BackgroundImage = Properties.Resources.screen_record;
                MessageBox.Show("Ekran Kaydı Kayıt Edildi");
            }
            else
            {
                ScreenUtil.initScreenRecord();
                await videoCapture1.StartAsync();
                isRecordStart = true;
                screenRecordButton.BackgroundImage = Properties.Resources.screen_record_red;

            }

        }

        // button control
        #endregion


        #region Arm Toggle Button
        
        private void deselectShoulderGroup()
        {
            DeselectButton(turretButton);
            DeselectButton(shoulderButton);
            DeselectButton(elbowButton);
        }
        private void deselectWristGroup()
        {
            DeselectButton(clampButton);
            DeselectButton(ptzButton);
            DeselectButton(wristButton);
        }
        private void turretButton_Click(object sender, EventArgs e)
        {
            if (isTurret)
            {
                DeselectButton(turretButton);
            }
            else
            {
                SelectButton(turretButton);
            }
            deselectWristGroup();
        }
        private void shoulderButton_Click(object sender, EventArgs e)
        {
            if (isShoulder)
            {
                DeselectButton(shoulderButton);
            }
            else
            {
                SelectButton(shoulderButton);

            }
            deselectWristGroup();
        }
        private void elbowButton_Click(object sender, EventArgs e)
        {
            if (isElbow)
            {
                DeselectButton(elbowButton);

            }
            else
            {
                SelectButton(elbowButton);
            }
            deselectWristGroup();
        }
        private void clampButton_Click(object sender, EventArgs e)
        {

            if (isClamp)
            {
                
                DeselectButton(clampButton);
            }
            else
            {
                SelectButton(clampButton);

            }
            deselectShoulderGroup();
            DeselectButton(wristButton);
            DeselectButton(ptzButton);



        }
        private void ptzButton_Click(object sender, EventArgs e)
        {
            if (isPtz)
            {
                
                DeselectButton(ptzButton);
            }
            else

            {

                SelectButton(ptzButton);

            }
            deselectShoulderGroup();
            DeselectButton(wristButton);
            DeselectButton(clampButton);
        }
        private void wristButton_Click(object sender, EventArgs e)
        {
            if (isWrist)
            {
                DeselectButton(wristButton);
            }
            else
            {
                SelectButton(wristButton);
            }
            deselectShoulderGroup();
            DeselectButton(ptzButton);
            DeselectButton(clampButton);
        }
        #endregion


        #region Light Menu
        private void frontLightButton_Click(object sender, EventArgs e)
        {
            if (isFrontLight)
            {
                DeselectButton(frontLightButton);
            }
            else
            {
                SelectButton(frontLightButton);
            }
        }

        private void backLightButton_Click(object sender, EventArgs e)
        {
            if (isBackLight)
            {
                DeselectButton(backLightButton);
            }
            else
            {
                SelectButton(backLightButton);
            }
        }

        private void armLightButton_Click(object sender, EventArgs e)
        {
            if (isArmLight)
            {
                DeselectButton(armLightButton);
            }
            else
            {
                SelectButton(armLightButton);
            }
        }

        private void aimLightButton_Click(object sender, EventArgs e)
        {
            if (isAimLight)
            {
                DeselectButton(aimLightButton);
            }
            else
            {
                SelectButton(aimLightButton);
            }
        }

        private void ptzLightTrackBar_Scroll(object sender, EventArgs e)
        {
            ptzLightLabel.Text = "PTZ " + ptzLightTrackBar.Value;
        }

        private void openLightMenuButton_Click(object sender, EventArgs e)
        {
            if (isLightMenu)
            {
                DeselectButton(openLightMenuButton);
                lightMenu.Visible = false;
            }
            else
            {
                SelectButton(openLightMenuButton);
                lightMenu.Visible = true;

            }
        }

        #endregion

        private void DeselectButton(Button button)
        {

            if (button == turretButton)
            {
                isTurret = false;

            }
            else if (button == shoulderButton)
            {
                isShoulder = false;
            }
            else if (button == elbowButton)
            {
                isElbow = false;
            }
            else if (button == wristButton)
            {
                isWrist = false;
            }
            else if (button == clampButton)
            {
                isClamp = false;
            }
            else if (button == ptzButton)
            {
                isPtz = false;
            }

            //Light 
            else if (button == openLightMenuButton)
            {
                isLightMenu = false;
            }
            else if (button == frontLightButton)
            {
                isFrontLight = false;
            }
            else if (button == backLightButton)
            {
                isBackLight = false;
            }
            else if (button == armLightButton)
            {
                isArmLight = false;
            }
            else if (button == aimLightButton)
            {
                isAimLight = false;
            }

            button.BackColor = Color.Lime;
            button.ForeColor = Color.Black;
        }
        private void SelectButton(Button button)
        {
            if (button == turretButton)
            {
                isTurret = true;

            }
            else if (button == shoulderButton)
            {
                isShoulder = true;
            }
            else if (button == elbowButton)
            {
                isElbow = true;
            }
            else if (button == wristButton)
            {
                isWrist = true;
            }
            else if (button == clampButton)
            {
                isClamp = true;
            }
            else if (button == ptzButton)
            {
                isPtz = true;
            }

            //Light
            else if (button == openLightMenuButton)
            {
                isLightMenu = true;
            }
            else if (button == frontLightButton)
            {
                isFrontLight = true;
            }
            else if (button == backLightButton)
            {
                isBackLight = true;
            }
            else if (button == armLightButton)
            {
                isArmLight = true;
            }
            else if (button == aimLightButton)
            {
                isAimLight = true;
            }
            button.BackColor = Color.Red;
            button.ForeColor = Color.White;
        }

       
        private void Form1_Click_1(object sender, EventArgs e)
        {
            //Close light menu
            DeselectButton(openLightMenuButton);
            lightMenu.Visible = false;
        }
    }
}
