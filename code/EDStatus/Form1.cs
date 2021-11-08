using EDStatus.UserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // timer1.Enabled = true;
        }

        DateTime _lastAccess = DateTime.MinValue;
        FlagValue _prevValue = new FlagValue("0"); 

        private readonly object _lock = new object();

        List<string> _commands = new List<string>(); 


        private void timer1_Tick(object sender, EventArgs e)
        {
            // fires on a tick

            var statusFile = new FileInfo(txtStatus.Text);

            if (statusFile.LastWriteTimeUtc == _lastAccess) return; 

            lock(_lock)
            {

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (Stream input = File.OpenRead(txtStatus.Text))
                    {
                        input.CopyTo(memoryStream);
                    }

                    memoryStream.Position = 0;

                    dynamic DynamicData = JsonConvert.DeserializeObject(
                            new StreamReader(memoryStream).ReadToEnd());
                    
                    var str = DynamicData.Flags.ToString(); 

                    var flags = new FlagValue(str);
                    PopulateTickboxes(flags);
                    var list = GenerateCommands();
                    Run(list); 

                }
            }

            // Console.WriteLine("timestamp: {0}", DynamicData.timestamp);
            // Console.WriteLine("Flags: {0}", DynamicData.Flags); 
        }

        private void PopulateTickboxes(FlagValue flags)
        {
            ucLandingGearDown.Checked = flags.LandingGearDown();
            ucFlightAssist.Checked = flags.FlightAssistOff();
            ucLights.Checked = flags.LightsOn();
            ucCargoScoop.Checked = flags.CargoScoopDeployed();
            ucNightVision.Checked = flags.NightVision(); 
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Testing");

            int i = 1;
            int mask = 2;

            Debug.WriteLine("{0}", i & mask);


            Debug.WriteLine("{0}", 101 & 1);

            var o = 101 & 1;

            Debug.WriteLine(o.ToString());

            Debug.WriteLine("101 & 8 {0}", 101 & 8);
            Debug.WriteLine("101 & 16 {0}", 101 & 16);
            Debug.WriteLine("101 & 32 {0}", 101 & 32);
            Debug.WriteLine("101 & 64 {0}", 101 & 64);

        }

        private void cmdTestFlags_Click(object sender, EventArgs e)
        {
            var list = GenerateCommands();
            Run(list); 
        }

        private List<string> GenerateCommands()
        {
            var list = new List<string>();
            string str;

            // ucLandingGearDown
            list.Add(string.Format("{0} {1} {2}", txtVid.Text, txtPID.Text, GetControlValue(ucLandingGearDown)));

            // ucFlightAssist
            list.Add(string.Format("{0} {1} {2}", txtVid.Text, txtPID.Text, GetControlValue(ucFlightAssist)));

            // ucLights
            list.Add(string.Format("{0} {1} {2}", txtVid.Text, txtPID.Text, GetControlValue(ucLights)));

            // ucCargoScoop
            list.Add(string.Format("{0} {1} {2}", txtVid.Text, txtPID.Text, GetControlValue(ucCargoScoop)));

            // ucNightVision
            list.Add(string.Format("{0} {1} {2}", txtVid.Text, txtPID.Text, GetControlValue(ucNightVision)));



            return list; 

        }

        private string GetControlValue( ucFlagAction ctl)
        {




            return string.Format("{0} {1}", ctl.LED, ctl.Checked ? ctl.ON : ctl.OFF);
        }


        private void Run(List<string> list)
        {
            var mpc = string.Format(@"""{0}""", txtVirLed.Text);
            foreach ( var param in list)
            {
                System.Diagnostics.Process.Start(mpc, param);
                Application.DoEvents(); 
            }
            
        }

        private void cmdEnable_Click(object sender, EventArgs e)
        {
            var txt = cmdEnable.Text; 

            if ( string.Compare(txt, "Enable", true ) == 0 )
            {
                timer1.Enabled = true;
                cmdEnable.Text = "Disable"; 
            }
            else
            {
                timer1.Enabled = false;
                cmdEnable.Text = "Enable";
            }
        }
    }
}
