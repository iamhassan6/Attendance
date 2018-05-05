using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstP.DATA;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace FirstP
{
    public partial class Form2 : Form
    {
        int id=0;
        private DataModel db = new DataModel();
        public Form2()
        {
            InitializeComponent();
            cv.Items.Add("BlackListed");
            cv.Items.Add("Not Balcklisted");
            cv.Items.Add("All");
            updatetable();
        }
        public void updatetable()
        {
            var a = db.Employees.Select(e => new { e.eid, e.ename, e.efname, e.empnic, e.PHS }).OrderBy(e => e.eid).ToList();
            dgv.DataSource = a;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(en.Text)) && (string.IsNullOrWhiteSpace(nic.Text)) && (string.IsNullOrWhiteSpace(phs.Text)))
            {
                MessageBox.Show("All Fields should be filled", "Error");
                //db.Employees.Add()
            }
            else
            {
                var em = db.Employees.Where(ep => ep.empnic == nictext.Text).ToList();
                if (em.Count > 0)
                {
                    MessageBox.Show("Employee is already in record", "Warning");
                }
                else
                {
                    var emp = new Employee();
                    emp.ename = en.Text;
                    emp.efname = fn.Text;
                    emp.empnic = nic.Text;
                    emp.PHS = decimal.Parse(phs.Text);
                    emp.bl = 0;
                    db.Employees.Add(emp);
                    db.SaveChanges();
                    en.Text = "";
                    fn.Text = "";
                    nic.Text = "";
                    phs.Text = "";
                    updatetable();
                }

            }
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

       

        private void dgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
            {
                return;
            }
            else
            {
                id = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                //dgv.SelectedRows[e.RowIndex].Cells[1].ToString();
                en.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                fn.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                nic.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                phs.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
                //button3.Visible = false;
                //button2.Visible = true;
                //button1.Visible = true;
            }
        }

        private void ub_Click(object sender, EventArgs e)
        {
            var u = db.Employees.First(e1 => e1.eid == id);
            u.ename = en.Text;
            u.efname = fn.Text;
            u.empnic = nic.Text;
            u.bl = 0;
            u.PHS = decimal.Parse(phs.Text.ToString());
            db.SaveChanges();
            updatetable();
            en.Text = "";
            fn.Text = "";
            nic.Text = "";
            phs.Text = "";
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rd =  MessageBox.Show("Are u sure to BlackList Employee ID "+id+" ", "Confirmation Box", MessageBoxButtons.YesNo, 
            MessageBoxIcon.Information);
            if(rd == DialogResult.Yes)
            {
                Form5 f5 = new Form5(id);
                f5.Show();
            }
        }

        private void cv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cv.SelectedIndex == 0)
            {
                var a = db.Employees.Where(e1=> e1.bl==1).Select(e1 => new { e1.eid, e1.ename, e1.efname, e1.empnic, e1.PHS }).OrderBy(e1 => e1.eid).ToList();
                dgv.DataSource = a;
                en.Text = "";
                fn.Text = "";
                nic.Text = "";
                phs.Text = "";
                ubl.Visible = true;
                button3.Visible = false;
                button2.Visible = true;
                button1.Visible = false;
            }
            else if (cv.SelectedIndex == 1)
            {
                var a = db.Employees.Where(e1 => e1.bl != 1).Select(e1 => new { e1.eid, e1.ename, e1.efname, e1.empnic, e1.PHS }).OrderBy(e1 => e1.eid).ToList();
                dgv.DataSource = a;
                en.Text = "";
                fn.Text = "";
                nic.Text = "";
                phs.Text = "";
                ubl.Visible = false;
                button3.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
            }
            else if (cv.SelectedIndex == 2)
            {
                updatetable();
                en.Text = "";
                fn.Text = "";
                nic.Text = "";
                phs.Text = "";
                button3.Visible = true;
                ubl.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
            }
        }

        private void ubl_Click(object sender, EventArgs e)
        {
            DialogResult rd = MessageBox.Show("Are u sure to Un BlackList Employee ID " + id + " ", "Confirmation Box", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);
            if (rd == DialogResult.Yes)
            {
                Form5 f5 = new Form5(id);
                f5.Show();
            }
        }
    }
}
