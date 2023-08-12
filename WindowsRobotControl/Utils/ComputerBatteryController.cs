using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsRobotControl.Utils {
    internal class ComputerBatteryController {

        private System.Timers.Timer timer;
        private Form1 form1;

        public ComputerBatteryController(Form1 form1) {
            this.form1 = form1;
            timer = new System.Timers.Timer();
            timer.Interval = 120000; // 2 dakika (120,000 milisaniye)
            timer.Elapsed += TimerElapsed;
            RefreshBatteryInfo();
            timer.Start();

        }

        private void TimerElapsed(object sender, ElapsedEventArgs e) {
            
            RefreshBatteryInfo();
            timer.Start();
        }

        string batteryLevel;
        string batteryStatus;

        private void RefreshBatteryInfo() {

            try {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Battery");
                foreach (ManagementObject battery in searcher.Get()) {
                    batteryStatus = battery["BatteryStatus"].ToString();
                    string batteryHealth = battery["Status"].ToString();
                    batteryLevel = battery["EstimatedChargeRemaining"].ToString();

                    batteryStatus = batteryStatus == "2" ? "Şarj Ediliyor" : "Şarj Edilmiyor";
                    string health = batteryHealth == "OK" ? "Sağlıklı" : "Değil";
                    MessageBox.Show(batteryLevel);
                    form1.panelBatteryButton.Text = batteryLevel + batteryStatus;
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
