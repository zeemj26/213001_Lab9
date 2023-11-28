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

namespace 213043_Example05
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
            cmd.CommandText = "SELECT COUNT(*) FROM dbo.region"; Int32 count =
            (Int32)cmd.ExecuteScalar();
             static public int AddProductCategory(string newName, string connString)
             {
            Int32 newProdID = 0; string sql = "INSERT INTO Production.ProductCategory (Name)
            VALUES(@Name); " + "SELECT CAST(scope_identity() AS int)";
             using (SqlConnection conn = new SqlConnection(connString))
                {
                SqlCommand cmd = new SqlCommand(sql, conn); cmd.Parameters.Add("@Name",
                SqlDbType.VarChar); cmd.Parameters["@name"].Value = newName;
                try
                {
                   conn.Open();
                   newProdID = (Int32)cmd.ExecuteScalar();
                } catch (Exception ex)
                 { 
                    Console.WriteLine(ex.Message);
                }
                 }
                return (int)newProdID;
            }
        }
    }
}
