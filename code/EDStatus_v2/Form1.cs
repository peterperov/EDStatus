using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLEDCONTROL;

namespace EDStatus_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            Debug.WriteLine(AppSettings.CONTROL_PANEL_1);

        }





        private void cmdResetColors_Click(object sender, EventArgs e)
        {
            var black = new LedColor(0, 0, 0);

            var device = AppSettings.GetDevice(VirpilDevices.THROTTLE);
            for (int i = device.LED_MIN; i <= device.LED_MAX; i++)
            {
                device.SendCommand(i, black); 
            }

            device = AppSettings.GetDevice(VirpilDevices.CONTROL_PANEL_1);
            for (int i = device.LED_MIN; i <= device.LED_MAX; i++)
            {
                device.SendCommand(i, black);
            }

            device = AppSettings.GetDevice(VirpilDevices.CONTROL_PANEL_2);
            for (int i = device.LED_MIN; i <= device.LED_MAX; i++)
            {
                device.SendCommand(i, black);
            }


        }
    }
}
