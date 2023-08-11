using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace WindowsRobotControl.udp
{
    internal class UdpSender
    {

        private UdpClient udpClient;
        IPEndPoint robotIpEndPoint;

        UdpSender()
        {
            InitializeUdpSender();
        }

        private void InitializeUdpSender()
        {
            udpClient = new UdpClient();
            robotIpEndPoint = new IPEndPoint(IPAddress.Parse(DataClass.ROBOT_MAIN_IP), DataClass.UDP_PORT);
        }
  

        public void SendUdpData(byte[] data)
        {
            try
            {
                udpClient.Send(data, data.Length, robotIpEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
