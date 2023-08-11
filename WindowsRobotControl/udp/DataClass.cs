using GLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsRobotControl.udp
{
    internal class DataClass
    {
        public static  int RECONNECTION_PERIOD = 5000, CONNECTION_STATUS_REFRESH_PERIOD = 2000;
        public static  int SEND_PERIOD = 95;
        public static  String ROBOT_MAIN_IP = "192.168.3.2";//"192.168.1.2";
        public static  int UDP_PORT = 10006, SOUND_STREAMING_PORT = 10007;
        public static  int COMMAND_SIZE = 6;
        public static  byte C = (byte)0x43, R = (byte)0x52;
        

        public static  byte EMERGENCY_STOP = (byte)0xEF;
        public static  byte LIMIT_MOTORS = (byte)0x40, APPLY_LIMITS = (byte)0x01, REMOVE_LIMITS = (byte)0x00;

        public static  int CMD_INDEX = 2, D1_INDEX = 3, D0_INDEX = 4, CS_INDEX = 5;
        public static  int ACC_INDEX = D1_INDEX, P_INDEX = D0_INDEX;
        public static  int I_INDEX = D1_INDEX, D_INDEX = D0_INDEX;

        public static  byte PARAM1 = (byte)0xF1, PARAM2 = (byte)0xF2, PARAM3 = (byte)0xF3, PARAM4 = (byte)0xF4, PARAM5 = (byte)0xF5, PARAM6 = (byte)0xF6, PARAM7 = (byte)0xF7, PARAM8 = (byte)0xF8;

        public static  byte TURRET_POSE = (byte)0x3A, SHOULDER_POSE = (byte)0x31, ELBOW_POSE = (byte)0x32, WRIST_POSE = (byte)0x33, CLAMP_POSE = (byte)0x34, CLAMP_TURRET_POSE = (byte)0x39, FRONT_PAL_POSE = (byte)0x36, BACK_PAL_POSE = (byte)0x37, POSE_STATUS = (byte)0x38;
      

        public static  byte BACK_LIGHT = (byte)0x10;
        public static  byte ARM_LIGHT = (byte)0x15;
        public static  byte CLAMP_LIGHT = (byte)0x35;

        public static  byte AKER_FIRE = (byte)0x25;

        public static  byte IR_CONTROL = (byte)0x7C;
        public static  byte LIMIT_CONTROL = (byte)0x5A;

        public static  byte SHOULDER_RESET = (byte)0xE7;
        public static  byte TURRET_RESET = (byte)0xE8;
        public static  byte ELBOW_RESET = (byte)0xE9;
        public static  byte WRIST_RESET = (byte)0xEA;
        public static  byte FRONTPAL_RESET = (byte)0xEB;
        public static  byte BACKPAL_RESET = (byte)0xEC;
        public static  byte CLAMP_RESET = (byte)0xED;
        public static  byte CLAMP_TURRET_RESET = (byte)0xEE;
        public static  byte TELESKOP_RESET = (byte)0xD7;

        public static  byte MEMS_WRITE = (byte)0x48;
        public static  byte MEMS_X_READ = (byte)0x48;
        public static  byte MEMS_Y_READ = (byte)0x49;
        public static  byte MEMS_Z_READ = (byte)0x4A;
        public static  byte BATTERY_READ = (byte)0x4B;

        public static  byte TEMPERATURE_READ = (byte)0x1E;

        public static  byte SOUND = (byte)0x50, SOUND_OFF = (byte)0x00, SOUND_MAX = (byte)0x63, SOUND_MIN = (byte)0x30, SOUND_TEST = (byte)0x01;
        public static  byte SOUND_REPLY = (byte)0X41;


        public static  int PTZ_MAX_SPEED = 63, PAN_SPEED_INDEX = D1_INDEX, TILT_SPEED_INDEX = D0_INDEX;

        public static  byte PTZ_UP = (byte)0x28;
        public static  byte PTZ_DOWN = (byte)0x21;
        public static  byte PTZ_LEFT = (byte)0x24;
        public static  byte PTZ_RIGHT = (byte)0x22;

        //Diagonal Motion
        public static  byte PTZ_UP_LEFT = (byte)0x2B;
        public static  byte PTZ_UP_RIGHT = (byte)0x2A;
        public static  byte PTZ_DOWN_LEFT = (byte)0x25;
        public static  byte PTZ_DOWN_RIGHT = (byte)0x23;


        public static  byte PTZ_ZOOMIN = (byte)0x27;
        public static  byte PTZ_ZOOMOUT = (byte)0x26;

        //Halil Ptz 
        public static  byte PTZ_HORIZONTAL = (byte)0x21;
        public static  byte PTZ_VERTICAL = (byte)0x24;

        public static  int PRESET_ID_INDEX = D0_INDEX;
        public static  byte PTZ_SET_PRESET = (byte)0x29;
        public static  byte PTZ_GOTO_PRESET = (byte)0x2C;
        public static  byte PTZ_QUERY_PAN = (byte)0x2D;
        public static  byte PTZ_QUERY_TILT = (byte)0x2E;
        public static  byte PTZ_QUERY_ZOOM = (byte)0x2F;
        public static  byte PTZ_PAN = (byte)0x59;
        public static  byte PTZ_TILT = (byte)0x5B;
        public static  byte PTZ_ZOOM = (byte)0x5D;
        public static  byte PTZ_LIGHT = (byte)0x20;
    }
}
