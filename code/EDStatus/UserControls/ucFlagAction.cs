using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDStatus.UserControls
{
    public partial class ucFlagAction : UserControl
    {
        public ucFlagAction()
        {
            InitializeComponent();
        }

        public string FlagName
        {
            get
            {
                return checkBox1.Text; 
            }
            set
            {
                checkBox1.Text = value; 
            }
        }

        public bool FlagValue
        {
            get
            {
                return checkBox1.Checked; 
            }
            set
            {
                checkBox1.Checked = value; 
            }
        }


        public string LED
        {
            get { return txtLED.Text;  }
            set { txtLED.Text = value; }
        }

        public string ON
        {
            get { return txtON.Text; }
            set { txtON.Text = value; }
        }

        public string OFF
        {
            get { return txtOff.Text;  }
            set { txtOff.Text = value; }
        }

        public bool Checked
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

    }
}
