namespace FirstP
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bb = new System.Windows.Forms.Button();
            this.ub = new System.Windows.Forms.Button();
            this.ab = new System.Windows.Forms.Button();
            this.nictext = new System.Windows.Forms.TextBox();
            this.sal = new System.Windows.Forms.TextBox();
            this.efntext = new System.Windows.Forms.TextBox();
            this.enametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.efn = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ubl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nic = new System.Windows.Forms.TextBox();
            this.phs = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.en = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cv = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bb);
            this.groupBox1.Controls.Add(this.ub);
            this.groupBox1.Controls.Add(this.ab);
            this.groupBox1.Controls.Add(this.nictext);
            this.groupBox1.Controls.Add(this.sal);
            this.groupBox1.Controls.Add(this.efntext);
            this.groupBox1.Controls.Add(this.enametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.efn);
            this.groupBox1.Controls.Add(this.ename);
            this.groupBox1.Location = new System.Drawing.Point(1, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(297, 140);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(75, 23);
            this.bb.TabIndex = 6;
            this.bb.Text = "Black List";
            this.bb.UseVisualStyleBackColor = true;
            // 
            // ub
            // 
            this.ub.Location = new System.Drawing.Point(159, 140);
            this.ub.Name = "ub";
            this.ub.Size = new System.Drawing.Size(111, 23);
            this.ub.TabIndex = 5;
            this.ub.Text = "Update Employee";
            this.ub.UseVisualStyleBackColor = true;
            this.ub.Visible = false;
            // 
            // ab
            // 
            this.ab.Location = new System.Drawing.Point(159, 140);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(95, 23);
            this.ab.TabIndex = 4;
            this.ab.Text = "Add Employee";
            this.ab.UseVisualStyleBackColor = true;
            // 
            // nictext
            // 
            this.nictext.Location = new System.Drawing.Point(261, 86);
            this.nictext.Name = "nictext";
            this.nictext.Size = new System.Drawing.Size(122, 20);
            this.nictext.TabIndex = 1;
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(38, 86);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(122, 20);
            this.sal.TabIndex = 1;
            // 
            // efntext
            // 
            this.efntext.Location = new System.Drawing.Point(261, 34);
            this.efntext.Name = "efntext";
            this.efntext.Size = new System.Drawing.Size(122, 20);
            this.efntext.TabIndex = 1;
            // 
            // enametxt
            // 
            this.enametxt.Location = new System.Drawing.Point(38, 34);
            this.enametxt.Name = "enametxt";
            this.enametxt.Size = new System.Drawing.Size(122, 20);
            this.enametxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Per Hour Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee NIC Number";
            // 
            // efn
            // 
            this.efn.AutoSize = true;
            this.efn.Location = new System.Drawing.Point(258, 17);
            this.efn.Name = "efn";
            this.efn.Size = new System.Drawing.Size(117, 13);
            this.efn.TabIndex = 0;
            this.efn.Text = "Employee Father Name";
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Location = new System.Drawing.Point(35, 17);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(84, 13);
            this.ename.TabIndex = 0;
            this.ename.Text = "Employee Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportingToolStripMenuItem1,
            this.attendanceToolStripMenuItem});
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
            this.reportingToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.reportingToolStripMenuItem1.Text = "Reporting";
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.byDateToolStripMenuItem.Text = "By Date";
            // 
            // todayAttendanceToolStripMenuItem
            // 
            this.todayAttendanceToolStripMenuItem.Name = "todayAttendanceToolStripMenuItem";
            this.todayAttendanceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.todayAttendanceToolStripMenuItem.Text = "Perious Attendance";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 232);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(493, 150);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ubl);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.nic);
            this.groupBox2.Controls.Add(this.phs);
            this.groupBox2.Controls.Add(this.fn);
            this.groupBox2.Controls.Add(this.en);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Employee";
            // 
            // ubl
            // 
            this.ubl.Location = new System.Drawing.Point(297, 140);
            this.ubl.Name = "ubl";
            this.ubl.Size = new System.Drawing.Size(75, 23);
            this.ubl.TabIndex = 7;
            this.ubl.Text = "UnBlock";
            this.ubl.UseVisualStyleBackColor = true;
            this.ubl.Visible = false;
            this.ubl.Click += new System.EventHandler(this.ubl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Black List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.ub_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // nic
            // 
            this.nic.Location = new System.Drawing.Point(261, 86);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(122, 20);
            this.nic.TabIndex = 4;
            // 
            // phs
            // 
            this.phs.Location = new System.Drawing.Point(38, 86);
            this.phs.Name = "phs";
            this.phs.Size = new System.Drawing.Size(122, 20);
            this.phs.TabIndex = 3;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(261, 34);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(122, 20);
            this.fn.TabIndex = 2;
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(38, 34);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(122, 20);
            this.en.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Per Hour Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee NIC Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee Father Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee Name";
            // 
            // cv
            // 
            this.cv.FormattingEnabled = true;
            this.cv.Location = new System.Drawing.Point(160, 27);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(121, 21);
            this.cv.TabIndex = 7;
            this.cv.Text = "Select View of LIst";
            this.cv.SelectedIndexChanged += new System.EventHandler(this.cv_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.cv);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ab;
        private System.Windows.Forms.TextBox nictext;
        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.TextBox efntext;
        private System.Windows.Forms.TextBox enametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label efn;
        private System.Windows.Forms.Label ename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ub;
        private System.Windows.Forms.Button bb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nic;
        private System.Windows.Forms.TextBox phs;
        private System.Windows.Forms.TextBox en;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.ComboBox cv;
        private System.Windows.Forms.Button ubl;
    }
}