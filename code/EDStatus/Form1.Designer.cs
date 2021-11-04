
namespace EDStatus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdTest = new System.Windows.Forms.Button();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVirLed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucLandingGearDown = new EDStatus.UserControls.ucFlagAction();
            this.cmdTestFlags = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdTestFlags);
            this.groupBox1.Controls.Add(this.cmdTest);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVirLed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1486, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configs";
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(873, 39);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(130, 35);
            this.cmdTest.TabIndex = 8;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(271, 121);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(86, 31);
            this.txtPID.TabIndex = 7;
            this.txtPID.Text = "0194";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PID:";
            // 
            // txtVid
            // 
            this.txtVid.Location = new System.Drawing.Point(119, 121);
            this.txtVid.Name = "txtVid";
            this.txtVid.Size = new System.Drawing.Size(86, 31);
            this.txtVid.TabIndex = 5;
            this.txtVid.Text = "3344";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "VID:";
            // 
            // txtVirLed
            // 
            this.txtVirLed.Location = new System.Drawing.Point(119, 71);
            this.txtVirLed.Name = "txtVirLed";
            this.txtVirLed.Size = new System.Drawing.Size(652, 31);
            this.txtVirLed.TabIndex = 3;
            this.txtVirLed.Text = "C:\\Program Files (x86)\\VPC Software Suite\\tools>VPC_LED_Control.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Virpil Led:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(119, 34);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(652, 31);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "C:\\Users\\peter\\Saved Games\\Frontier Developments\\Elite Dangerous\\Status.json";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucLandingGearDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 628);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flags";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucLandingGearDown
            // 
            this.ucLandingGearDown.FlagName = "LandingGearDown";
            this.ucLandingGearDown.FlagValue = false;
            this.ucLandingGearDown.LED = "05";
            this.ucLandingGearDown.Location = new System.Drawing.Point(18, 31);
            this.ucLandingGearDown.Name = "ucLandingGearDown";
            this.ucLandingGearDown.OFF = "00 00 00";
            this.ucLandingGearDown.ON = "00 FF 00";
            this.ucLandingGearDown.Size = new System.Drawing.Size(753, 37);
            this.ucLandingGearDown.TabIndex = 0;
            // 
            // cmdTestFlags
            // 
            this.cmdTestFlags.Location = new System.Drawing.Point(873, 114);
            this.cmdTestFlags.Name = "cmdTestFlags";
            this.cmdTestFlags.Size = new System.Drawing.Size(130, 35);
            this.cmdTestFlags.TabIndex = 9;
            this.cmdTestFlags.Text = "TestFlags";
            this.cmdTestFlags.UseVisualStyleBackColor = true;
            this.cmdTestFlags.Click += new System.EventHandler(this.cmdTestFlags_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 826);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVirLed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdTest;
        private UserControls.ucFlagAction ucLandingGearDown;
        private System.Windows.Forms.Button cmdTestFlags;
    }
}

