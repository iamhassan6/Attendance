namespace FirstP
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.atten = new System.Windows.Forms.Button();
            this.outi = new System.Windows.Forms.DateTimePicker();
            this.inti = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.CheckBox();
            this.a = new System.Windows.Forms.CheckBox();
            this.dcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datep = new System.Windows.Forms.DateTimePicker();
            this.ntxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hrtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eidtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.atten);
            this.groupBox2.Controls.Add(this.outi);
            this.groupBox2.Controls.Add(this.inti);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.b);
            this.groupBox2.Controls.Add(this.a);
            this.groupBox2.Controls.Add(this.dcb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.datep);
            this.groupBox2.Controls.Add(this.ntxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.hrtxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.eidtxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(32, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendence";
            // 
            // atten
            // 
            this.atten.Location = new System.Drawing.Point(376, 209);
            this.atten.Name = "atten";
            this.atten.Size = new System.Drawing.Size(75, 23);
            this.atten.TabIndex = 15;
            this.atten.Text = "Attend";
            this.atten.UseVisualStyleBackColor = true;
            this.atten.Click += new System.EventHandler(this.atten_Click);
            // 
            // outi
            // 
            this.outi.CustomFormat = "hh:mm tt";
            this.outi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.outi.Location = new System.Drawing.Point(207, 212);
            this.outi.Name = "outi";
            this.outi.ShowUpDown = true;
            this.outi.Size = new System.Drawing.Size(106, 20);
            this.outi.TabIndex = 5;
            this.outi.Value = new System.DateTime(2018, 4, 21, 11, 13, 5, 0);
            // 
            // inti
            // 
            this.inti.CustomFormat = "hh:mm tt";
            this.inti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inti.Location = new System.Drawing.Point(41, 212);
            this.inti.Name = "inti";
            this.inti.ShowUpDown = true;
            this.inti.Size = new System.Drawing.Size(123, 20);
            this.inti.TabIndex = 4;
            this.inti.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Out Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "In Time";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(304, 132);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(57, 17);
            this.b.TabIndex = 7;
            this.b.Text = "Shift B";
            this.b.UseVisualStyleBackColor = true;
            this.b.CheckedChanged += new System.EventHandler(this.b_CheckedChanged);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(207, 132);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(57, 17);
            this.a.TabIndex = 6;
            this.a.Text = "Shift A";
            this.a.UseVisualStyleBackColor = true;
            this.a.CheckedChanged += new System.EventHandler(this.a_CheckedChanged);
            // 
            // dcb
            // 
            this.dcb.FormattingEnabled = true;
            this.dcb.Location = new System.Drawing.Point(38, 135);
            this.dcb.Name = "dcb";
            this.dcb.Size = new System.Drawing.Size(121, 21);
            this.dcb.TabIndex = 5;
            this.dcb.Text = "Select Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Department";
            // 
            // datep
            // 
            this.datep.Location = new System.Drawing.Point(207, 91);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(200, 20);
            this.datep.TabIndex = 2;
            // 
            // ntxt
            // 
            this.ntxt.Location = new System.Drawing.Point(207, 52);
            this.ntxt.Name = "ntxt";
            this.ntxt.Size = new System.Drawing.Size(100, 20);
            this.ntxt.TabIndex = 2;
            this.ntxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ntxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // hrtxt
            // 
            this.hrtxt.Enabled = false;
            this.hrtxt.Location = new System.Drawing.Point(38, 91);
            this.hrtxt.Name = "hrtxt";
            this.hrtxt.Size = new System.Drawing.Size(100, 20);
            this.hrtxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Name";
            // 
            // eidtxt
            // 
            this.eidtxt.Location = new System.Drawing.Point(38, 48);
            this.eidtxt.Name = "eidtxt";
            this.eidtxt.Size = new System.Drawing.Size(100, 20);
            this.eidtxt.TabIndex = 1;
            this.eidtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eidtxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem1,
            this.addEmployeeToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reportingToolStripMenuItem.Text = "Options";
            // 
            // reportingToolStripMenuItem1
            // 
            this.reportingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byDateToolStripMenuItem,
            this.todayAttendanceToolStripMenuItem});
            this.reportingToolStripMenuItem1.Name = "reportingToolStripMenuItem1";
            this.reportingToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.reportingToolStripMenuItem1.Text = "Reporting";
            this.reportingToolStripMenuItem1.Click += new System.EventHandler(this.reportingToolStripMenuItem1_Click);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.byDateToolStripMenuItem.Text = "By Date";
            this.byDateToolStripMenuItem.Click += new System.EventHandler(this.byDateToolStripMenuItem_Click);
            // 
            // todayAttendanceToolStripMenuItem
            // 
            this.todayAttendanceToolStripMenuItem.Name = "todayAttendanceToolStripMenuItem";
            this.todayAttendanceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.todayAttendanceToolStripMenuItem.Text = "Perious Attendance";
            this.todayAttendanceToolStripMenuItem.Click += new System.EventHandler(this.todayAttendanceToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox b;
        private System.Windows.Forms.CheckBox a;
        private System.Windows.Forms.ComboBox dcb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datep;
        private System.Windows.Forms.TextBox ntxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hrtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eidtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker outi;
        private System.Windows.Forms.DateTimePicker inti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button atten;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
    }
}

