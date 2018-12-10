using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            if (!panel2.Controls.Contains(customerinfo.Instance))
            {
                panel2.Controls.Add(customerinfo.Instance);
                customerinfo.Instance.Dock = DockStyle.Fill;
                customerinfo.Instance.BringToFront();
            }
        }

        private void custdetails_Click(object sender, EventArgs e)
        {
            customerinfo.Instance.BringToFront();
        }

        private void staffdetails_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(staffinfo.Instance))
            {
                panel2.Controls.Add(staffinfo.Instance);
                staffinfo.Instance.Dock = DockStyle.Fill;
                staffinfo.Instance.BringToFront();
            }
            else
            {
                staffinfo.Instance.BringToFront();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            this.Hide();
            fo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(cust_emp.Instance))
            {
                panel2.Controls.Add(cust_emp.Instance);
                cust_emp.Instance.Dock = DockStyle.Fill;
                cust_emp.Instance.BringToFront();
            }
            else
            {
                cust_emp.Instance.BringToFront();
            }

        }
    }
}
