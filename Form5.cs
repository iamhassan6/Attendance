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

namespace FirstP
{
    public partial class Form5 : Form
    {
        int eid;
        private DataModel db = new DataModel();
        public Form5(int id)
        {
            InitializeComponent();
            eid = id;
            var b = db.Blacks.Where(b1 => b1.eid == id).SingleOrDefault();
            if (b != null)
            {
                rm.Text = b.remarks;
                button2.Visible = true;
                button1.Visible = false;
            }
            var a = db.Employees.Where(e => e.eid == id).SingleOrDefault();
            namtxt.Text = a.ename;
            nictxt.Text = a.empnic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var e1 = db.Employees.Where(ee => ee.eid == eid).SingleOrDefault();
            e1.bl = 1;
            db.SaveChanges();
            var a = new Black();
            a.eid = eid;
            a.nic = nictxt.Text;
            a.remarks = rm.Text;
            a.dated = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Blacks.Add(a);
            if (db.SaveChanges() == 1)
            {
                MessageBox.Show("Blacklisted");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var e1 = db.Employees.Where(ee => ee.eid == eid).SingleOrDefault();
            e1.bl = 0;
            if (db.SaveChanges() == 1)
            {
                MessageBox.Show("UnBlacklisted");
                this.Close();
            }
        }
    }
}
