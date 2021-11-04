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
        private readonly object _lock = new object();

        List<Tuple<string, string>> _commands = new List<Tuple<string, string>>(); 


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
                }
            }



            // Console.WriteLine("timestamp: {0}", DynamicData.timestamp);
            // Console.WriteLine("Flags: {0}", DynamicData.Flags); 

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

        }

        private List<Tuple<string, string>> GenerateCommands()
        {
            var list = new List<Tuple<string, string>>();
            string str;

            // ucLandingGearDown
            str = string.Format("{0} {1} {2} {3}",
                txtVirLed.Text, txtVid.Text, txtPID.Text); 



            return list; 

        }


        private void Run()
        {
            var mpc = "";
            var param = ""; 

            System.Diagnostics.Process.Start(mpc, param);
        }

    }
}
