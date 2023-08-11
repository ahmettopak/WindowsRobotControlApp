using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRobotControl.Utils
{
    internal class Utils
    {

        public static void RefreshBatteryInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Battery");
                foreach (ManagementObject battery in searcher.Get())
                {
                    string batteryStatus = battery["BatteryStatus"].ToString();
                    string batteryHealth = battery["Status"].ToString();
                    string batteryLevel = battery["EstimatedChargeRemaining"].ToString();

                    string status = batteryStatus == "2" ? "Şarj Ediliyor" : "Şarj Edilmiyor";
                    string health = batteryHealth == "OK" ? "Sağlıklı" : "Değil";

                    MessageBox.Show(health + status + batteryLevel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
