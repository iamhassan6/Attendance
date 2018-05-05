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
using System.Data.SqlClient;
using System.Configuration;

namespace FirstP
{
    public partial class Form1 : Form
    {
        private DataModel db = new DataModel();
        private Model db1 = new Model();
        private char shft;
        public Form1()
        {
            InitializeComponent();
            var dep = db.Departs.ToList();
            foreach (var item in dep)
            {
                dcb.Items.Add(item.depname);
            }
            //DateTime lastday = DateTime.Now;
            //lastday= db.Attens.Max(a => a.Dte).Value;
            //if (lastday.Date < DateTime.Now.Date)
            //{
            //    var att = from e in db.Employees
            //              where !db.Blacks.Where(b=> b.eid==e.eid && b.nic==e.empnic).Any() && !db.Attens.Where(a=> a.Dte==lastday).Any(a=> a.eid==e.eid)
            //              select e;
            //    foreach (var item in att)
            //    {
            //        var at = new Atten();
            //        at.eid = item.eid;
            //        at.Dte = lastday;
            //        at.enic = item.empnic;
            //        at.hrs = 0;
            //        at.intime = TimeSpan.Zero;
            //        at.outtime = TimeSpan.Zero;
            //        db1.Attens.Add(at);
            //        db1.SaveChanges();
            //    }
                //var att = new List<Employee>();
                //var att = from e in db.Employees
                //          where (!db1.Attens.Where(a=> a.Dte==lastday).Any(a => a.eid == e.eid))
                //          select e;
                //var re = db.Employees.Where(e => !db1.Attens.Any(a => a.eid == e.eid));
                //MessageBox.Show(att.Count().ToString());
            }        
        

        


        private void ntxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var a = db.Employees.Where(em => em.empnic == ntxt.Text).Select(em => new { em.eid, em.ename}).SingleOrDefault();
                if (a!=null)
                {
                    eidtxt.Text = a.eid.ToString();
                    hrtxt.Text = a.ename;
                    
                }
                else
                {
                    MessageBox.Show("No Employee found of NIC " + ntxt.Text + "", "Error");
                }
            }
        }

        private void ovti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                //hutxt.Text=th.ToString();

            }
        }

        private void eidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                int id = int.Parse(eidtxt.Text);
                var a1 = db.Employees.Where(em => em.eid == id).Select(em => new {em.empnic ,em.ename}).SingleOrDefault();
                if (a1 != null)
                {
                    ntxt.Text = a1.empnic;
                    hrtxt.Text = a1.ename;
                }
                else
                {
                    MessageBox.Show("No Employee found of ID " + eidtxt.Text + "", "Error");
                }
            }
        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {
            if (a.Checked == true)
            {
                shft = 'A';
                b.Checked = false;
            }
            
        }

        private void b_CheckedChanged(object sender, EventArgs e)
        {
            if (b.Checked == true) { 
                shft = 'B';
                a.Checked = false;
            }

        }

        private void atten_Click(object sender, EventArgs e)
        {
            int n = int.Parse(eidtxt.Text);
            var bl = db.Employees.Where(e1 => e1.eid == n).Select(e1 => e1.bl).First();
            if (bl==1)
            {
                MessageBox.Show("Employee is BlackListed");
            }
            else
            {
                var ta = db1.Attens.Where(x => x.eid == n && x.Dte == datep.Value).ToList();
                if (ta.Count > 0)
                {
                    MessageBox.Show("Attendace for Employee ID " + n + " is already in the system");
                }
                else
                {
                    DateTime intime;
                    intime = inti.Value;
                    TimeSpan into = new TimeSpan(intime.Hour, intime.Minute, intime.Second);
                    DateTime outime = outi.Value;
                    TimeSpan outo = new TimeSpan(outime.Hour, outime.Minute, outime.Second);
                    var at = new Atten();
                    at.Dte = datep.Value;
                    at.shft = shft.ToString();
                    at.intime = into;
                    at.outtime = outo;
                    if (intime > outime)
                    {
                        at.hrs = -1 * decimal.Parse(outime.Subtract(intime).TotalHours.ToString());
                    }
                    else
                    {
                        at.hrs = decimal.Parse(outime.Subtract(intime).TotalHours.ToString());
                    }
                    if (dcb.SelectedIndex < 0)
                    {
                        MessageBox.Show("Department is not selected");
                    }
                    else
                    {
                        at.edep = dcb.SelectedItem.ToString();
                        at.eid = n;
                        at.enic = ntxt.Text;
                        db.Attens.Add(at);
                        if (db.SaveChanges() == 1)
                        {
                            MessageBox.Show("Attendance Inserted");
                            datep.Value = DateTime.Now;
                            ntxt.Text = "";
                            dcb.SelectedIndex = 0;
                            eidtxt.Text = "";
                            dcb.Text = "Select Department";
                            a.Checked = false;
                            b.Checked = false;
                            hrtxt.Text="";
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    
                }
               
            }
        }

        private void reportingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void todayAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
