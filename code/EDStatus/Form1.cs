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
using VLEDCONTROL;

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

        Dictionary<string, bool> _prevValues = new Dictionary<string, bool>(); 


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

            FlagValues i = (FlagValues) 63;


            Debug.WriteLine("Docked {0}", i.HasFlag(FlagValues.Docked)); 
            Debug.WriteLine("Landed {0}", i.HasFlag(FlagValues.Landed)); 
            Debug.WriteLine("LandingGearDown {0}", i.HasFlag(FlagValues.LandingGearDown)); 
            Debug.WriteLine("ShieldsUp {0}", i.HasFlag(FlagValues.ShieldsUp)); 




        }

        private void cmdTestFlags_Click(object sender, EventArgs e)
        {
            var list = GenerateCommands();
            Run(list); 
        }

        private List<string> GenerateCommands()
        {
            var list = new List<string>();

            

            list.AddRange(GetControlValue(ucLandingGearDown)); 
            list.AddRange(GetControlValue(ucFlightAssist)); 
            list.AddRange(GetControlValue(ucLights)); 
            list.AddRange(GetControlValue(ucCargoScoop)); 
            list.AddRange(GetControlValue(ucNightVision)); 

            return list; 

        }

        private List<string> GetControlValue( ucFlagAction ctl)
        {

            var list = new List<string>();
            var leds = ctl.LED;

            // sanity 
            if (string.IsNullOrEmpty(leds)) return list;

            // check with prev value 
            var key = ctl.FlagName;
            var val = ctl.Checked;

            if (!_prevValues.ContainsKey(key))
            {
                // opposite so that initial update always fires 
                _prevValues[key] = !val;
            }

            if ( _prevValues[key] != val)
            {
                foreach (var led in leds.Split(','))
                {
                    // 
                    list.Add(string.Format("{0} {1} {2} {3}", txtVid.Text, txtPID.Text,
                        led, ctl.Checked ? ctl.ON : ctl.OFF));
                }
            }

            // save prev value
            _prevValues[key] = ctl.Checked; 

            return list; 
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

        private void cmdTestDirect_Click(object sender, EventArgs e)
        {
            // testing direct communication 

            var device = new VirpilDevice("control panel #2", "3344", "025B");
            var color = new LedColor(64, 64, 64);

            device.SendCommand(9, color); 

        }

        private void cmdWatcher_Click(object sender, EventArgs e)
        {

        }
    }
}
