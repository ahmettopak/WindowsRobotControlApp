using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsRobotControl.udp
{
    internal class UdpUtils
    {

        public byte[] GenerateUdpData(byte id , byte d0, byte d1)
        {
      
            byte[] udpData = new byte[6];
            udpData[0] = DataClass.C;
            udpData[1] = DataClass.R;
            udpData[2] = id;
            udpData[3] = d0;
            udpData[4] = d1;
            udpData[5] = GenerateChecksum(id , d0 , d1);

            return udpData;
        }

        public static bool ValidateChecksum(byte id, byte d0, byte d1, byte checksum)
        {

            byte cs = (byte)((id + d0 + d1) % 256);
            if (cs == checksum)
            {
                return true;
            }
            return false;
        }

        public static byte GenerateChecksum(byte id, byte d0, byte d1)
        {
            return (byte)((id + d0 + d1) % 256);
        }


        public string ByteToHex(byte value)
        {
            return value.ToString("X2");
        }

        public static string[] ByteArrayToHexArray(byte[] byteArray)
        {
            string[] hexArray = new string[byteArray.Length];

            for (int i = 0; i < byteArray.Length; i++)
            {
                hexArray[i] = byteArray[i].ToString("X2");
            }

            return hexArray;
        }
    }
}
