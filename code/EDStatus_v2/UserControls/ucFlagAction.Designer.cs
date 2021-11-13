
namespace EDStatus_v2.UserControls
{
    partial class ucFlagAction
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtLED = new System.Windows.Forms.TextBox();
            this.txtON = new System.Windows.Forms.TextBox();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtLED
            // 
            this.txtLED.Location = new System.Drawing.Point(490, 1);
            this.txtLED.Name = "txtLED";
            this.txtLED.Size = new System.Drawing.Size(59, 31);
            this.txtLED.TabIndex = 2;
            // 
            // txtON
            // 
            this.txtON.Location = new System.Drawing.Point(623, 1);
            this.txtON.Name = "txtON";
            this.txtON.Size = new System.Drawing.Size(115, 31);
            this.txtON.TabIndex = 3;
            // 
            // txtOff
            // 
            this.txtOff.Location = new System.Drawing.Point(799, 1);
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(115, 31);
            this.txtOff.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LED#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "OFF:";
            // 
            // selDevice
            // 
            this.selDevice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selDevice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selDevice.FormattingEnabled = true;
            this.selDevice.Items.AddRange(new object[] {
            "THROTTLE",
            "CONTROL_PANEL_1",
            "CONTROL_PANEL_2"});
            this.selDevice.Location = new System.Drawing.Point(210, 1);
            this.selDevice.Name = "selDevice";
            this.selDevice.Size = new System.Drawing.Size(203, 33);
            this.selDevice.TabIndex = 8;
            // 
            // ucFlagAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selDevice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOff);
            this.Controls.Add(this.txtON);
            this.Controls.Add(this.txtLED);
            this.Controls.Add(this.checkBox1);
            this.Name = "ucFlagAction";
            this.Size = new System.Drawing.Size(917, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtLED;
        private System.Windows.Forms.TextBox txtON;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selDevice;
    }
}
