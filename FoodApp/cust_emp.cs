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
    public partial class cust_emp : UserControl
    {
        private static cust_emp _instance;
        public static cust_emp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new cust_emp();
                }
                return _instance;
            }
        }
        public cust_emp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from relations ", con);
                DataTable ta = new DataTable();
                da.Fill(ta);
                dataGridView1.DataSource = ta;
            }
        }
    }
}
