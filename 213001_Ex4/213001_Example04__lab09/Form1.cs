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

namespace _213043_Example04__lab09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=DESKTOP-46PNOSO\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            try
            { 
                conn.Open();
                MessageBox.Show("Connection successfull..");
                string qry = "Select * from Student";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr["Roll_no"].ToString());
                }
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        }
}

