using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    public partial class TodaySpecial : UserControl
    {
        private static TodaySpecial _instance;
        public static TodaySpecial Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TodaySpecial();
                }
                return _instance;
            }
        }
        public TodaySpecial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(VegFood.Instance))
            {
                panel1.Controls.Add(VegFood.Instance);
                VegFood.Instance.Dock = DockStyle.Fill;
                VegFood.Instance.BringToFront();
            }
            else
            {
                VegFood.Instance.BringToFront();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
