using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213043_Example05_Lab09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "Data Source=DESKTOP-46PNOSO\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            String query = "Insert Into shop.Customer(CustomerID,CompanyName) Values(213,'Dalda')";
            SqlCommand cmd = new SqlCommand(query, conn);   
            cmd.Connection.Open();
            int res = cmd.ExecuteNonQuery();
        }
    }
}
