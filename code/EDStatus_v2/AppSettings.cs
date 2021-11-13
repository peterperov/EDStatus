using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLEDCONTROL;

namespace EDStatus_v2
{
    public class AppSettings
    {


        public static string THROTTLE = "VPC Throttle";
        public static string CONTROL_PANEL_1 = "VPC Panel #1"; 
        public static string CONTROL_PANEL_2 = "VPC Panel #2"; 

        static Dictionary<VirpilDevices, VirpilDevice> _dic;

        static List<VirpilDevice> _list;




        static AppSettings()
        {
            _dic = new Dictionary<VirpilDevices, VirpilDevice>();
            _list = new List<VirpilDevice>();

            Init(); 
        }


        /*
         
        VPC Throttle    3344 0194
        VPC Panel #1    3344 0259
        VPC Panel #2    3344 025B

        */

        static void Init()
        {

            var device = new VirpilDevice(VirpilDevices.THROTTLE, "3344", "0194", 5, 10); 
            _list.Add(device);
            _dic.Add(device.DeviceType, device); 

            device = new VirpilDevice(VirpilDevices.CONTROL_PANEL_1, "3344", "0259", 5, 16);
            _list.Add(device);
            _dic.Add(device.DeviceType, device);

            device = new VirpilDevice(VirpilDevices.CONTROL_PANEL_2, "3344", "025B", 5, 21);
            _list.Add(device);
            _dic.Add(device.DeviceType, device);
        }

        public static VirpilDevice GetDevice(VirpilDevices name)
        {
            if (_dic.ContainsKey(name)) return _dic[name];
            else
                return null; 
        }


    }
}
