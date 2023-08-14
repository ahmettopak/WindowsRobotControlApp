using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Core.Metadata.KLV.MISB0601;

namespace WindowsRobotControl.udp
{
    internal class UdpReceiver
    {

        UdpClient udpClient = new UdpClient(DataClass.UDP_PORT);
        Form1 form1;

        public UdpReceiver(Form1 form1)
        {
            this.form1 = form1;
        }
        public async void StartListening()
        {
            

            try
            {
                while (true)
                {
                    
                    UdpReceiveResult result = await udpClient.ReceiveAsync();

                    byte[] data = result.Buffer;

                    if (data.Length == 6)
                    {
                        String[] hexData = UdpUtils.ByteArrayToHexArray(data);
                       if (UdpUtils.ValidateReceivePacket(data))
                        {
                            byte id = data[2];
                            byte d0 = data[3];
                            byte d1 = data[4];
                            string fullValue = hexData[3] + hexData[4];

                            if (id == DataClass.BATTERY_READ)
                            {
                                form1.robotBatteryButton.Text = "%" + UdpUtils.ToInt(fullValue);
                            }
                           

                            string message = $"ID: {id}, Variable: {d0}, Variable2: {d1}";

                            form1.listBox1.Items.Add(message);
                        }
                 
                      
                        
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
