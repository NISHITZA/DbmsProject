using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodApp
{
    public partial class staff : UserControl
    {
        private static staff _instance;
        public static staff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new staff();
                }
                return _instance;
            }
        }
        public staff()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from systemTable where username='" + box1.Text + "' and password='" + box2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                admin ad = new admin();
                this.Hide();
                ad.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password");
            }


        }

        private void staff_Load(object sender, EventArgs e)
        {

        }
    }
}
