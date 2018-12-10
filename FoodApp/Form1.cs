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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!panelk.Controls.Contains(home.Instance))
            {
                panelk.Controls.Add(home.Instance);
                home.Instance.Dock = DockStyle.Fill;
                home.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelk.Controls.Contains(staff.Instance))
            {
                panelk.Controls.Add(staff.Instance);
                staff.Instance.Dock = DockStyle.Fill;
                staff.Instance.BringToFront();
            }
            else
            {
                staff.Instance.BringToFront();
            }
        }
    }
}
