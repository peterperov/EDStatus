using EDStatus_v2.DataHolders;
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

namespace EDStatus_v2.UserControls
{
    public partial class ucEliteDangerous : UserControl
    {

        public static int FULL_UPDATE = 5000; 


        public ucEliteDangerous()
        {
            InitializeComponent();

            InitUI(); 
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {

            var device = AppSettings.GetDevice(VirpilDevices.THROTTLE);

            var color = new LedColor(64, 64, 64);
            var some = new LedColor(128, 64, 64);
            var strong = new LedColor(128, 128, 128);
            var black = new LedColor(0, 0, 0); 

            device.SendCommand(5, some);
            device.SendCommand(6, strong);
            device.SendCommand(7, color);
            device.SendCommand(8, black);
            device.SendCommand(9, color);
            device.SendCommand(10, color);


        }

        public void InitUI()
        {

            ucDocked.Device = VirpilDevices.CONTROL_PANEL_2;
            ucLanded.Device = VirpilDevices.CONTROL_PANEL_2;
            ucLandedGearDown.Device = VirpilDevices.CONTROL_PANEL_2;
            ucShieldUp.Device = VirpilDevices.CONTROL_PANEL_2;

            ucSupercruise.Device = VirpilDevices.CONTROL_PANEL_2;
            ucFlightAssistOff.Device = VirpilDevices.CONTROL_PANEL_2;
            ucHardpointsDeployed.Device = VirpilDevices.CONTROL_PANEL_2;
            ucLightsOn.Device = VirpilDevices.CONTROL_PANEL_2;

            ucCargoScoopDeployed.Device = VirpilDevices.CONTROL_PANEL_2;
            ucSilentRunning.Device = VirpilDevices.CONTROL_PANEL_2;
            ucScoopingFuel.Device = VirpilDevices.CONTROL_PANEL_2;
            ucSrvHandbrake.Device = VirpilDevices.CONTROL_PANEL_2;

            ucSrvDriveAssist.Device = VirpilDevices.CONTROL_PANEL_2;
            ucFsdMassLocked.Device = VirpilDevices.CONTROL_PANEL_2;
            ucFsdCharging.Device = VirpilDevices.CONTROL_PANEL_2;
            ucFsdCooldown.Device = VirpilDevices.CONTROL_PANEL_2;

            ucOverHeating.Device = VirpilDevices.CONTROL_PANEL_2;
            ucIsInDanger.Device = VirpilDevices.CONTROL_PANEL_2;
            ucBeingInterdicted.Device = VirpilDevices.CONTROL_PANEL_2;
            ucNightVision.Device = VirpilDevices.CONTROL_PANEL_2;
            ucAnalysisMode.Device = VirpilDevices.CONTROL_PANEL_2;
            ucsrvHighBeam.Device = VirpilDevices.CONTROL_PANEL_2;


            // note Functors override text boxes behaviour, sometimes taking some values from them
            ucNightVision.Function = (val, ctl) =>
            {
                var list = new List<DeviceCommand>();

                // black
                LedColor color = new LedColor(ctl.OFF); 

                // both are on
                if ( val.HasFlag(FlagValues.NightVision) & val.HasFlag(FlagValues.LightsOn ) )
                {
                    color = new LedColor("00 40 40"); 
                }
                else if (val.HasFlag(FlagValues.NightVision) & !val.HasFlag(FlagValues.LightsOn))
                {
                    color = new LedColor("00 00 40");
                }
                else if (!val.HasFlag(FlagValues.NightVision) & val.HasFlag(FlagValues.LightsOn))
                {
                    color = new LedColor("40 40 40");
                }

                var leds = ctl.LED.Split(","); 
                foreach ( var led in leds)
                {
                    list.Add(new DeviceCommand(ctl.Device, int.Parse(led), color));
                }

                return list; 
            }; 


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        FileSystemWatcher _watcher = null; 

        private void cmdFileWatcher_Click(object sender, EventArgs e)
        {

            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Saved Games\\Frontier Developments\\Elite Dangerous";
            // watcher.Path = path;

            if (cmdFileWatcher.Text.Equals("Enable FileWatcher"))
            {
                StartWatcher();
                cmdFileWatcher.Text = "Disable FileWatcher";
            }
            else
            {
                EndWatcher();
                cmdFileWatcher.Text = "Enable FileWatcher";
            }

        }

        private void StartWatcher()
        {
            // var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Saved Games\\Frontier Developments\\Elite Dangerous";


            _watcher = new FileSystemWatcher(); 
            _watcher.Path = Path.GetDirectoryName(txtStatus.Text);

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            _watcher.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;

            // Only watch JSON files.
            _watcher.Filter = "*.json";

            // Add event handlers.
            _watcher.Changed += OnChanged;
            // _watcher.Created += OnCreated;
            // _watcher.Deleted += OnDeleted;
            // _watcher.Renamed += OnRenamed;

            // Begin watching.
            _watcher.EnableRaisingEvents = true;

        }

        object _lock = new object();

        FlagValues _prev;
        DateTime _prevTimeStamp;
        FlagValues _current; 

        private void OnChanged(object source, FileSystemEventArgs e)
        {

            if (e.Name.Equals("Status.json"))
            {
                /*
                                Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
                                Thread updateThread = new Thread(() => ReadStatusFile(e.FullPath))
                                {
                                    IsBackground = true
                                };
                                updateThread.Start();
                */
                var statusFile = new FileInfo(e.FullPath);

                lock (_lock)
                {

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        //using (Stream input = File.OpenRead(statusFile.FullName))
                        // using (FileStream fs = new FileStream(statusFile.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        using (FileStream input = new FileStream(statusFile.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            input.CopyTo(memoryStream);
                        }

                        memoryStream.Position = 0;
                        var content = new StreamReader(memoryStream).ReadToEnd(); 
                        if ( string.IsNullOrEmpty(content))
                        {
                            Debug.WriteLine("emtpy string - exiting");
                            return; 
                        }


                        Debug.WriteLine(content); 

                        memoryStream.Position = 0;

                        //dynamic DynamicData = JsonConvert.DeserializeObject(new StreamReader(memoryStream).ReadToEnd());

                        dynamic DynamicData = JsonConvert.DeserializeObject(content);

                        string str = DynamicData.Flags.ToString();
                        Debug.WriteLine("Flags {0}", str); 

                        // _current = new FlagValue(str);

                        uint _number; 
                        if (!UInt32.TryParse(str, out _number))
                        {
                            _number = 0;
                        }
                        _current = (FlagValues) _number; 
                    }

                    // we're still locked here!
                    PopulateValues(_current);

                } // end lock

                


            }
        }

        private void EndWatcher()
        {
            if (_watcher != null)
            {
                _watcher.EnableRaisingEvents = true;
                _watcher = null; 
            }
        }


        private void PopulateValues(FlagValues val)
        {
            PopulateUIDispatcher( val); 

        }

        // HACK: threaded hack
        private delegate void populateUIDelegate(FlagValues val);

        private void PopulateUIDispatcher( FlagValues val)
        {
            if (this.InvokeRequired)
            {
                populateUIDelegate dd = PopulateUI;
                this.Invoke(dd, new object[] { val });
            }
            else
            {
                PopulateUI(val); 
            }
        }

        private void PopulateUI(FlagValues val)
        {
            // diff? 

            ucDocked.Checked = val.HasFlag(FlagValues.Docked);
            ucLanded.Checked = val.HasFlag(FlagValues.Landed);
            ucLandedGearDown.Checked = val.HasFlag(FlagValues.LandingGearDown);
            ucShieldUp.Checked = val.HasFlag(FlagValues.ShieldsUp);
            ucSupercruise.Checked = val.HasFlag(FlagValues.Supercruise);
            ucFlightAssistOff.Checked = val.HasFlag(FlagValues.FlightAssistOff);
            ucHardpointsDeployed.Checked = val.HasFlag(FlagValues.HardpointsDeployed);
            ucLightsOn.Checked = val.HasFlag(FlagValues.LightsOn);
            ucCargoScoopDeployed.Checked = val.HasFlag(FlagValues.CargoScoopDeployed);
            ucSilentRunning.Checked = val.HasFlag(FlagValues.SilentRunning);
            ucScoopingFuel.Checked = val.HasFlag(FlagValues.ScoopingFuel);
            ucSrvHandbrake.Checked = val.HasFlag(FlagValues.SrvHandbrake);
            ucSrvDriveAssist.Checked = val.HasFlag(FlagValues.SrvDriveAssist);
            ucFsdMassLocked.Checked = val.HasFlag(FlagValues.FsdMassLocked);
            ucFsdCharging.Checked = val.HasFlag(FlagValues.FsdCharging);
            ucFsdCooldown.Checked = val.HasFlag(FlagValues.FsdCooldown);
            ucOverHeating.Checked = val.HasFlag(FlagValues.OverHeating);
            ucIsInDanger.Checked = val.HasFlag(FlagValues.IsInDanger);
            ucBeingInterdicted.Checked = val.HasFlag(FlagValues.BeingInterdicted);
            ucNightVision.Checked = val.HasFlag(FlagValues.NightVision);
            ucAnalysisMode.Checked = val.HasFlag(FlagValues.AnalysisMode); 
            ucsrvHighBeam.Checked = val.HasFlag(FlagValues.srvHighBeam);

            var list = GetCommadsFromUI(val);
            SendCommands(list);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var led = new LedColor(64, 64, 64);

            Debug.WriteLine(led.ToString());
            Debug.WriteLine(led.AsString());

            led = new LedColor("FF 00 FF");
            Debug.WriteLine(led.ToString());
            Debug.WriteLine(led.AsString());


        }


        public List<ucFlagAction> GetFlagActions()
        {

            var list = new List<ucFlagAction>(); 

            foreach ( var ctl in groupBox2.Controls)
            {
                if ( ctl.GetType() == typeof(ucFlagAction))
                {
                    list.Add((ucFlagAction)ctl); 
                }
            }

            // return groupBox2.Controls.Where( x => typeof(x) == typeof(ucFlagAction))); 
            return list; 

        }

        private void cmdSendUIValues_Click(object sender, EventArgs e)
        {
            // simple - we go through all controls and send whatever values we find 

            var list = GetCommadsFromUI(0);

            SendCommands(list); 

            foreach ( var item in list)
            {
                Debug.WriteLine(item.ToString()); 
            }

        }

        private List<DeviceCommand> GetCommadsFromUI(FlagValues flags)
        {
            var list = new List<DeviceCommand>();

            foreach (var ctl in GetFlagActions())
            {
                if (string.IsNullOrEmpty(ctl.LED) & ctl.Function == null) continue;

                if ( ctl.Function != null)
                {
                    list.AddRange(ctl.Function(flags, ctl)); 
                }
                else
                {
                    // device has a command
                    var leds = ctl.LED.Split(",");
                    foreach (var led in leds)
                    {
                        list.Add(new DeviceCommand(ctl.Device, int.Parse(led), new LedColor(ctl.Checked ? ctl.ON : ctl.OFF)));
                    }
                }


            }

            return list; 

        }


        DateTime _lastFullUpdate = DateTime.MinValue; 
        List<DeviceCommand> _lastFullUpdateCommands = null; 


        private void SendCommands( List<DeviceCommand> list)
        {

            var now = DateTime.Now;
            TimeSpan span = now.Subtract(_lastFullUpdate);

            var filteredList = new List<DeviceCommand>();

            // && _lastFullUpdateCommands == null
            if ( span.TotalMilliseconds >= FULL_UPDATE )
            {
                // send full update
                filteredList = list; 
                _lastFullUpdate = DateTime.Now;
                _lastFullUpdateCommands = list;
            }
            else
            {
                // only send the difference
                foreach ( var item in list)
                {
                    var found = _lastFullUpdateCommands.FirstOrDefault(x => x.GetHashCode() == item.GetHashCode()); 
                    if ( found == null )
                    {
                        filteredList.Add(item); 
                    }
                }
            }

            foreach (var item in list)
            {
                AppSettings.GetDevice(item.Device).SendCommand(item.Led, item.Color);
            }



        }

    }
}
