using System;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-46PNOSO\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
            string queryString = "SELECT CustomerID, CompanyName FROM dbo.Customers";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, con);
           
            SqlDataAdapter custAdapter = new SqlDataAdapter("SELECT * FROM dbo.Customers",con);
            SqlDataAdapter ordAdapter = new SqlDataAdapter("SELECT * FROM Orders",con);
            DataSet customerOrders = new DataSet();
            custAdapter.Fill(customerOrders, "Customers");
            ordAdapter.Fill(customerOrders, "Orders");
            DataRelation relation = customerOrders.Relations.Add("CustOrders",
            customerOrders.Tables["Customers"].Columns["CustomerID"],
            customerOrders.Tables["Orders"].Columns["CustomerID"]);
            foreach (DataRow pRow in customerOrders.Tables["Customers"].Rows)
            {
                Console.WriteLine(pRow["CustomerID"]);
                foreach (DataRow cRow in pRow.GetChildRows(relation))
                Console.WriteLine("\t" + cRow["OrderID"]);
            }
        }
    }
}



