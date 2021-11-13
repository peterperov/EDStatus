using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLEDCONTROL;

namespace EDStatus_v2.DataHolders
{

    public class DeviceCommand
    {

        VirpilDevices _Device;
        int _led;
        LedColor _Color;

        int _hash;

        public DeviceCommand(VirpilDevices device, int led, LedColor color)
        {
            _Device = device;
            _led = led;
            _Color = color;

            _hash = device.GetHashCode() ^ led.GetHashCode() ^ color.GetHashCode();
        }


        public VirpilDevices Device { get { return _Device; } }
        public int Led { get { return _led; } }
        public LedColor Color { get { return _Color; } }

        public override int GetHashCode()
        {
            return _hash;
        }


        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _Device, _led, _Color); 
        }

    }


}
