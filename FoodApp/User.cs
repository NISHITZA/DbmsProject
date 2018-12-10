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
    public partial class User : Form
    {

        public User()
        {
            InitializeComponent();
            if (!paneldo.Controls.Contains(TodaySpecial.Instance))
            {
                paneldo.Controls.Add(TodaySpecial.Instance);
                TodaySpecial.Instance.Dock = DockStyle.Fill;
                TodaySpecial.Instance.BringToFront();
            }
        }

        private void veg_Click(object sender, EventArgs e)
        {
            if (!paneldo.Controls.Contains(VegFood.Instance))
            {
                paneldo.Controls.Add(VegFood.Instance);
                VegFood.Instance.Dock = DockStyle.Fill;
                VegFood.Instance.BringToFront();
            }
            else
            {
                VegFood.Instance.BringToFront();
            }
        }

        private void All_Click(object sender, EventArgs e)
        {
            TodaySpecial.Instance.BringToFront();
        }

        private void nonveg_Click(object sender, EventArgs e)
        {
            if (!paneldo.Controls.Contains(NonvegFood.Instance))
            {
                paneldo.Controls.Add(NonvegFood.Instance);
                NonvegFood.Instance.Dock = DockStyle.Fill;
                NonvegFood.Instance.BringToFront();
            }
            else
            {
                NonvegFood.Instance.BringToFront();
            }
        }

        private void desert_Click(object sender, EventArgs e)
        {
            if (!paneldo.Controls.Contains(Desert.Instance))
            {
                paneldo.Controls.Add(Desert.Instance);
                Desert.Instance.Dock = DockStyle.Fill;
                Desert.Instance.BringToFront();
            }
            else
            {
                Desert.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!paneldo.Controls.Contains(checkout.Instance))
            {
                paneldo.Controls.Add(checkout.Instance);
                checkout.Instance.Dock = DockStyle.Fill;
                checkout.Instance.BringToFront();
            }
            else
            {
                checkout.Instance.BringToFront();
            }

        }
    }
}
