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
    public partial class checkout : UserControl
    {
        private static checkout _instance;
        public static checkout Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new checkout();
                }
                return _instance;
            }
        }
        public checkout()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private int getdata()
        {
            con.Open();
            string ise = home.username;
            cmd = new SqlCommand("select Bill from Customer where Customer_name='"+ise+"'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            int temp = (int)dr[0];
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bill = getdata();
            label2.Text = "Rs:" + bill;
            //MessageBox.Show("Final Bill:" + bill);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 op = new Form1();
            this.Hide();
            
            op.Show();

        }
    }
}
