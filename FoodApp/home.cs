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
    public partial class home : UserControl
    {
        public static String username;
        private static home _instance;
        public static home Instance
        {
            
            get
            {
                if(_instance==null)
                {
                    _instance = new home();
                }
                return _instance;
            }
        }
        public home()
        {
            InitializeComponent();

        }
        
       
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        private void sign_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int ech = random.Next(102, 103);
          
            int n = 0;
            username = textBox1.Text;
            SqlCommand cmd = new SqlCommand("NewCustomer",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Customer_name",textBox1.Text);
            cmd.Parameters.AddWithValue("@Table_no",textBox2.Text);
            cmd.Parameters.AddWithValue("@Bill",n);
            cmd.Parameters.AddWithValue("@Emp_id", ech);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            con.Close();




            User us = new User();
            this.Hide();
            us.Show();

        }
    }
}
