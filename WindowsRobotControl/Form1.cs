using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace WindowsRobotControl
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            InitializeCameraComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeVlcControl();
            leftCameraComboBox.SelectedIndex = 0;
            rightCameraComboBox.SelectedIndex = 0;

            ScreenUtil = new ScreenUtil(this);
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
                MessageBox.Show("Ekran Kaydı Kayıt Edildi");
            }
            else
            {
                ScreenUtil.initScreenRecord();
                await videoCapture1.StartAsync();
                isRecordStart = true;

            }

        } 
        #endregion
    }
}
