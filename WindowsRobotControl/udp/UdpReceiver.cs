using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsRobotControl.udp
{
    internal class UdpReceiver
    {

        UdpClient udpClient = new UdpClient(DataClass.UDP_PORT);
        public async void StartListening()
        {
            

            try
            {
                while (true)
                {
                    UdpReceiveResult result = await udpClient.ReceiveAsync();

                    byte[] data = result.Buffer;

                    if (data.Length >= 6)
                    {
                        String[] hexData = UdpUtils.ByteArrayToHexArray(data);
                        string address1 = hexData[0];
                        string address2 = hexData[1];
                        string id = hexData[2];
                        string variable = hexData[3];
                        string variable1 = hexData[4];
                        string checksum = hexData[5];
                        if (id == "34")
                        {
                            MessageBox.Show("sdads");
                        }
                        string message = $"Address: {address1}-{address2}, ID: {id}, Variable: {variable}, Variable2: {variable1}, Checksum: {checksum}";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
