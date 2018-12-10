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
    public partial class Desert : UserControl
    {
        private static Desert _instance;
        public static Desert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Desert();
                }
                return _instance;
            }
        }
        public Desert()
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
        private void updatedata(int bill)
        {
            con.Open();
            string ise = home.username;
            cmd = new SqlCommand("update Customer set Bill='" + bill + "' where Customer_name='"+ise+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bill = getdata();
            bill = bill + 90;
            MessageBox.Show("order is successful,Bill:" + bill);
            updatedata(bill);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bill = getdata();
            bill = bill + 65;
            MessageBox.Show("order is successful,Bill:" + bill);
            updatedata(bill);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bill = getdata();
            bill = bill + 90;
            MessageBox.Show("order is successful,Bill:" + bill);
            updatedata(bill);
        }
    }
}
