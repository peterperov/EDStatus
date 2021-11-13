
namespace EDStatus_v2.UserControls
{
    partial class ucEliteDangerous
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdFileWatcher = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucAnalysisMode = new EDStatus_v2.UserControls.ucFlagAction();
            this.cmdSendUIValues = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ucsrvHighBeam = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucNightVision = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucBeingInterdicted = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucIsInDanger = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucOverHeating = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucFsdCooldown = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucFsdCharging = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucFsdMassLocked = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucSrvDriveAssist = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucSrvHandbrake = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucScoopingFuel = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucSilentRunning = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucCargoScoopDeployed = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucLightsOn = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucHardpointsDeployed = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucFlightAssistOff = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucSupercruise = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucShieldUp = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucLandedGearDown = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucLanded = new EDStatus_v2.UserControls.ucFlagAction();
            this.ucDocked = new EDStatus_v2.UserControls.ucFlagAction();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdFileWatcher);
            this.groupBox1.Controls.Add(this.cmdTest);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1602, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // cmdFileWatcher
            // 
            this.cmdFileWatcher.Location = new System.Drawing.Point(978, 17);
            this.cmdFileWatcher.Name = "cmdFileWatcher";
            this.cmdFileWatcher.Size = new System.Drawing.Size(115, 91);
            this.cmdFileWatcher.TabIndex = 7;
            this.cmdFileWatcher.Text = "Enable FileWatcher";
            this.cmdFileWatcher.UseVisualStyleBackColor = true;
            this.cmdFileWatcher.Click += new System.EventHandler(this.cmdFileWatcher_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(828, 37);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(112, 34);
            this.cmdTest.TabIndex = 6;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(121, 39);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(652, 31);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "C:\\Users\\peter\\Saved Games\\Frontier Developments\\Elite Dangerous\\Status.json";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucAnalysisMode);
            this.groupBox2.Controls.Add(this.cmdSendUIValues);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ucsrvHighBeam);
            this.groupBox2.Controls.Add(this.ucNightVision);
            this.groupBox2.Controls.Add(this.ucBeingInterdicted);
            this.groupBox2.Controls.Add(this.ucIsInDanger);
            this.groupBox2.Controls.Add(this.ucOverHeating);
            this.groupBox2.Controls.Add(this.ucFsdCooldown);
            this.groupBox2.Controls.Add(this.ucFsdCharging);
            this.groupBox2.Controls.Add(this.ucFsdMassLocked);
            this.groupBox2.Controls.Add(this.ucSrvDriveAssist);
            this.groupBox2.Controls.Add(this.ucSrvHandbrake);
            this.groupBox2.Controls.Add(this.ucScoopingFuel);
            this.groupBox2.Controls.Add(this.ucSilentRunning);
            this.groupBox2.Controls.Add(this.ucCargoScoopDeployed);
            this.groupBox2.Controls.Add(this.ucLightsOn);
            this.groupBox2.Controls.Add(this.ucHardpointsDeployed);
            this.groupBox2.Controls.Add(this.ucFlightAssistOff);
            this.groupBox2.Controls.Add(this.ucSupercruise);
            this.groupBox2.Controls.Add(this.ucShieldUp);
            this.groupBox2.Controls.Add(this.ucLandedGearDown);
            this.groupBox2.Controls.Add(this.ucLanded);
            this.groupBox2.Controls.Add(this.ucDocked);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1602, 887);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Config";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ucAnalysisMode
            // 
            this.ucAnalysisMode.Checked = false;
            this.ucAnalysisMode.FlagName = "AnalysisMode";
            this.ucAnalysisMode.FlagValue = false;
            this.ucAnalysisMode.LED = "5,6,7,8";
            this.ucAnalysisMode.Location = new System.Drawing.Point(6, 707);
            this.ucAnalysisMode.Name = "ucAnalysisMode";
            this.ucAnalysisMode.OFF = "40 40 00";
            this.ucAnalysisMode.ON = "00 00 40";
            this.ucAnalysisMode.Size = new System.Drawing.Size(934, 40);
            this.ucAnalysisMode.TabIndex = 23;
            // 
            // cmdSendUIValues
            // 
            this.cmdSendUIValues.Location = new System.Drawing.Point(1064, 102);
            this.cmdSendUIValues.Name = "cmdSendUIValues";
            this.cmdSendUIValues.Size = new System.Drawing.Size(177, 34);
            this.cmdSendUIValues.TabIndex = 22;
            this.cmdSendUIValues.Text = "Send UI Values";
            this.cmdSendUIValues.UseVisualStyleBackColor = true;
            this.cmdSendUIValues.Click += new System.EventHandler(this.cmdSendUIValues_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1064, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "TEsting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucsrvHighBeam
            // 
            this.ucsrvHighBeam.Checked = false;
            this.ucsrvHighBeam.FlagName = "srvHighBeam";
            this.ucsrvHighBeam.FlagValue = false;
            this.ucsrvHighBeam.LED = "";
            this.ucsrvHighBeam.Location = new System.Drawing.Point(6, 788);
            this.ucsrvHighBeam.Name = "ucsrvHighBeam";
            this.ucsrvHighBeam.OFF = "";
            this.ucsrvHighBeam.ON = "";
            this.ucsrvHighBeam.Size = new System.Drawing.Size(934, 40);
            this.ucsrvHighBeam.TabIndex = 20;
            // 
            // ucNightVision
            // 
            this.ucNightVision.Checked = false;
            this.ucNightVision.FlagName = "NightVision";
            this.ucNightVision.FlagValue = false;
            this.ucNightVision.LED = "09";
            this.ucNightVision.Location = new System.Drawing.Point(6, 747);
            this.ucNightVision.Name = "ucNightVision";
            this.ucNightVision.OFF = "00 00 00";
            this.ucNightVision.ON = "00 00 40";
            this.ucNightVision.Size = new System.Drawing.Size(934, 40);
            this.ucNightVision.TabIndex = 19;
            // 
            // ucBeingInterdicted
            // 
            this.ucBeingInterdicted.Checked = false;
            this.ucBeingInterdicted.FlagName = "BeingInterdicted";
            this.ucBeingInterdicted.FlagValue = false;
            this.ucBeingInterdicted.LED = "";
            this.ucBeingInterdicted.Location = new System.Drawing.Point(6, 670);
            this.ucBeingInterdicted.Name = "ucBeingInterdicted";
            this.ucBeingInterdicted.OFF = "";
            this.ucBeingInterdicted.ON = "";
            this.ucBeingInterdicted.Size = new System.Drawing.Size(934, 40);
            this.ucBeingInterdicted.TabIndex = 18;
            // 
            // ucIsInDanger
            // 
            this.ucIsInDanger.Checked = false;
            this.ucIsInDanger.FlagName = "IsInDanger";
            this.ucIsInDanger.FlagValue = false;
            this.ucIsInDanger.LED = "";
            this.ucIsInDanger.Location = new System.Drawing.Point(6, 634);
            this.ucIsInDanger.Name = "ucIsInDanger";
            this.ucIsInDanger.OFF = "";
            this.ucIsInDanger.ON = "";
            this.ucIsInDanger.Size = new System.Drawing.Size(934, 40);
            this.ucIsInDanger.TabIndex = 17;
            // 
            // ucOverHeating
            // 
            this.ucOverHeating.Checked = false;
            this.ucOverHeating.FlagName = "OverHeating";
            this.ucOverHeating.FlagValue = false;
            this.ucOverHeating.LED = "";
            this.ucOverHeating.Location = new System.Drawing.Point(6, 600);
            this.ucOverHeating.Name = "ucOverHeating";
            this.ucOverHeating.OFF = "";
            this.ucOverHeating.ON = "";
            this.ucOverHeating.Size = new System.Drawing.Size(934, 40);
            this.ucOverHeating.TabIndex = 16;
            // 
            // ucFsdCooldown
            // 
            this.ucFsdCooldown.Checked = false;
            this.ucFsdCooldown.FlagName = "FsdCooldown";
            this.ucFsdCooldown.FlagValue = false;
            this.ucFsdCooldown.LED = "";
            this.ucFsdCooldown.Location = new System.Drawing.Point(6, 566);
            this.ucFsdCooldown.Name = "ucFsdCooldown";
            this.ucFsdCooldown.OFF = "";
            this.ucFsdCooldown.ON = "";
            this.ucFsdCooldown.Size = new System.Drawing.Size(934, 40);
            this.ucFsdCooldown.TabIndex = 15;
            // 
            // ucFsdCharging
            // 
            this.ucFsdCharging.Checked = false;
            this.ucFsdCharging.FlagName = "FsdCharging";
            this.ucFsdCharging.FlagValue = false;
            this.ucFsdCharging.LED = "";
            this.ucFsdCharging.Location = new System.Drawing.Point(6, 532);
            this.ucFsdCharging.Name = "ucFsdCharging";
            this.ucFsdCharging.OFF = "";
            this.ucFsdCharging.ON = "";
            this.ucFsdCharging.Size = new System.Drawing.Size(934, 40);
            this.ucFsdCharging.TabIndex = 14;
            // 
            // ucFsdMassLocked
            // 
            this.ucFsdMassLocked.Checked = false;
            this.ucFsdMassLocked.FlagName = "FsdMassLocked";
            this.ucFsdMassLocked.FlagValue = false;
            this.ucFsdMassLocked.LED = "";
            this.ucFsdMassLocked.Location = new System.Drawing.Point(6, 497);
            this.ucFsdMassLocked.Name = "ucFsdMassLocked";
            this.ucFsdMassLocked.OFF = "";
            this.ucFsdMassLocked.ON = "";
            this.ucFsdMassLocked.Size = new System.Drawing.Size(934, 40);
            this.ucFsdMassLocked.TabIndex = 13;
            // 
            // ucSrvDriveAssist
            // 
            this.ucSrvDriveAssist.Checked = false;
            this.ucSrvDriveAssist.FlagName = "SrvDriveAssist";
            this.ucSrvDriveAssist.FlagValue = false;
            this.ucSrvDriveAssist.LED = "";
            this.ucSrvDriveAssist.Location = new System.Drawing.Point(6, 462);
            this.ucSrvDriveAssist.Name = "ucSrvDriveAssist";
            this.ucSrvDriveAssist.OFF = "";
            this.ucSrvDriveAssist.ON = "";
            this.ucSrvDriveAssist.Size = new System.Drawing.Size(934, 40);
            this.ucSrvDriveAssist.TabIndex = 12;
            // 
            // ucSrvHandbrake
            // 
            this.ucSrvHandbrake.Checked = false;
            this.ucSrvHandbrake.FlagName = "SrvHandbrake";
            this.ucSrvHandbrake.FlagValue = false;
            this.ucSrvHandbrake.LED = "";
            this.ucSrvHandbrake.Location = new System.Drawing.Point(6, 426);
            this.ucSrvHandbrake.Name = "ucSrvHandbrake";
            this.ucSrvHandbrake.OFF = "";
            this.ucSrvHandbrake.ON = "";
            this.ucSrvHandbrake.Size = new System.Drawing.Size(934, 40);
            this.ucSrvHandbrake.TabIndex = 11;
            // 
            // ucScoopingFuel
            // 
            this.ucScoopingFuel.Checked = false;
            this.ucScoopingFuel.FlagName = "ScoopingFuel";
            this.ucScoopingFuel.FlagValue = false;
            this.ucScoopingFuel.LED = "";
            this.ucScoopingFuel.Location = new System.Drawing.Point(6, 389);
            this.ucScoopingFuel.Name = "ucScoopingFuel";
            this.ucScoopingFuel.OFF = "";
            this.ucScoopingFuel.ON = "";
            this.ucScoopingFuel.Size = new System.Drawing.Size(934, 40);
            this.ucScoopingFuel.TabIndex = 10;
            // 
            // ucSilentRunning
            // 
            this.ucSilentRunning.Checked = false;
            this.ucSilentRunning.FlagName = "SilentRunning";
            this.ucSilentRunning.FlagValue = false;
            this.ucSilentRunning.LED = "";
            this.ucSilentRunning.Location = new System.Drawing.Point(6, 353);
            this.ucSilentRunning.Name = "ucSilentRunning";
            this.ucSilentRunning.OFF = "";
            this.ucSilentRunning.ON = "";
            this.ucSilentRunning.Size = new System.Drawing.Size(934, 40);
            this.ucSilentRunning.TabIndex = 9;
            // 
            // ucCargoScoopDeployed
            // 
            this.ucCargoScoopDeployed.Checked = false;
            this.ucCargoScoopDeployed.FlagName = "CargoScoopDeployed";
            this.ucCargoScoopDeployed.FlagValue = false;
            this.ucCargoScoopDeployed.LED = "13";
            this.ucCargoScoopDeployed.Location = new System.Drawing.Point(6, 318);
            this.ucCargoScoopDeployed.Name = "ucCargoScoopDeployed";
            this.ucCargoScoopDeployed.OFF = "00 00 00";
            this.ucCargoScoopDeployed.ON = "40 40 00";
            this.ucCargoScoopDeployed.Size = new System.Drawing.Size(934, 40);
            this.ucCargoScoopDeployed.TabIndex = 8;
            // 
            // ucLightsOn
            // 
            this.ucLightsOn.Checked = false;
            this.ucLightsOn.FlagName = "LightsOn";
            this.ucLightsOn.FlagValue = false;
            this.ucLightsOn.LED = "";
            this.ucLightsOn.Location = new System.Drawing.Point(6, 283);
            this.ucLightsOn.Name = "ucLightsOn";
            this.ucLightsOn.OFF = "";
            this.ucLightsOn.ON = "";
            this.ucLightsOn.Size = new System.Drawing.Size(934, 40);
            this.ucLightsOn.TabIndex = 7;
            // 
            // ucHardpointsDeployed
            // 
            this.ucHardpointsDeployed.Checked = false;
            this.ucHardpointsDeployed.FlagName = "HardpointsDeployed";
            this.ucHardpointsDeployed.FlagValue = false;
            this.ucHardpointsDeployed.LED = "";
            this.ucHardpointsDeployed.Location = new System.Drawing.Point(6, 247);
            this.ucHardpointsDeployed.Name = "ucHardpointsDeployed";
            this.ucHardpointsDeployed.OFF = "";
            this.ucHardpointsDeployed.ON = "";
            this.ucHardpointsDeployed.Size = new System.Drawing.Size(934, 40);
            this.ucHardpointsDeployed.TabIndex = 6;
            // 
            // ucFlightAssistOff
            // 
            this.ucFlightAssistOff.Checked = false;
            this.ucFlightAssistOff.FlagName = "FlightAssistOff";
            this.ucFlightAssistOff.FlagValue = false;
            this.ucFlightAssistOff.LED = "19";
            this.ucFlightAssistOff.Location = new System.Drawing.Point(6, 211);
            this.ucFlightAssistOff.Name = "ucFlightAssistOff";
            this.ucFlightAssistOff.OFF = "40 00 40";
            this.ucFlightAssistOff.ON = "00 00 00";
            this.ucFlightAssistOff.Size = new System.Drawing.Size(934, 40);
            this.ucFlightAssistOff.TabIndex = 5;
            // 
            // ucSupercruise
            // 
            this.ucSupercruise.Checked = false;
            this.ucSupercruise.FlagName = "Supercruise";
            this.ucSupercruise.FlagValue = false;
            this.ucSupercruise.LED = "10";
            this.ucSupercruise.Location = new System.Drawing.Point(6, 175);
            this.ucSupercruise.Name = "ucSupercruise";
            this.ucSupercruise.OFF = "00 00 00";
            this.ucSupercruise.ON = "00 00 40";
            this.ucSupercruise.Size = new System.Drawing.Size(934, 40);
            this.ucSupercruise.TabIndex = 4;
            // 
            // ucShieldUp
            // 
            this.ucShieldUp.Checked = false;
            this.ucShieldUp.FlagName = "ShieldsUp";
            this.ucShieldUp.FlagValue = false;
            this.ucShieldUp.LED = "11,15";
            this.ucShieldUp.Location = new System.Drawing.Point(6, 139);
            this.ucShieldUp.Name = "ucShieldUp";
            this.ucShieldUp.OFF = "40 00 00";
            this.ucShieldUp.ON = "00 40 00";
            this.ucShieldUp.Size = new System.Drawing.Size(934, 40);
            this.ucShieldUp.TabIndex = 3;
            // 
            // ucLandedGearDown
            // 
            this.ucLandedGearDown.Checked = false;
            this.ucLandedGearDown.FlagName = "LandedGearDown";
            this.ucLandedGearDown.FlagValue = false;
            this.ucLandedGearDown.LED = "12,14";
            this.ucLandedGearDown.Location = new System.Drawing.Point(6, 102);
            this.ucLandedGearDown.Name = "ucLandedGearDown";
            this.ucLandedGearDown.OFF = "00 00 00";
            this.ucLandedGearDown.ON = "00 40 00";
            this.ucLandedGearDown.Size = new System.Drawing.Size(934, 40);
            this.ucLandedGearDown.TabIndex = 2;
            // 
            // ucLanded
            // 
            this.ucLanded.Checked = false;
            this.ucLanded.FlagName = "Landed";
            this.ucLanded.FlagValue = false;
            this.ucLanded.LED = "";
            this.ucLanded.Location = new System.Drawing.Point(6, 66);
            this.ucLanded.Name = "ucLanded";
            this.ucLanded.OFF = "";
            this.ucLanded.ON = "";
            this.ucLanded.Size = new System.Drawing.Size(934, 40);
            this.ucLanded.TabIndex = 1;
            // 
            // ucDocked
            // 
            this.ucDocked.Checked = false;
            this.ucDocked.FlagName = "Docked";
            this.ucDocked.FlagValue = false;
            this.ucDocked.LED = "";
            this.ucDocked.Location = new System.Drawing.Point(6, 30);
            this.ucDocked.Name = "ucDocked";
            this.ucDocked.OFF = "";
            this.ucDocked.ON = "";
            this.ucDocked.Size = new System.Drawing.Size(934, 40);
            this.ucDocked.TabIndex = 0;
            // 
            // ucEliteDangerous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucEliteDangerous";
            this.Size = new System.Drawing.Size(1602, 1001);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdTest;
        private ucFlagAction ucDocked;
        private ucFlagAction ucsrvHighBeam;
        private ucFlagAction ucNightVision;
        private ucFlagAction ucBeingInterdicted;
        private ucFlagAction ucIsInDanger;
        private ucFlagAction ucOverHeating;
        private ucFlagAction ucFsdCooldown;
        private ucFlagAction ucFsdCharging;
        private ucFlagAction ucFsdMassLocked;
        private ucFlagAction ucSrvDriveAssist;
        private ucFlagAction ucSrvHandbrake;
        private ucFlagAction ucScoopingFuel;
        private ucFlagAction ucSilentRunning;
        private ucFlagAction ucCargoScoopDeployed;
        private ucFlagAction ucLightsOn;
        private ucFlagAction ucHardpointsDeployed;
        private ucFlagAction ucFlightAssistOff;
        private ucFlagAction ucSupercruise;
        private ucFlagAction ucShieldUp;
        private ucFlagAction ucLandedGearDown;
        private ucFlagAction ucLanded;
        private System.Windows.Forms.Button cmdFileWatcher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSendUIValues;
        private ucFlagAction ucAnalysisMode;
    }
}
