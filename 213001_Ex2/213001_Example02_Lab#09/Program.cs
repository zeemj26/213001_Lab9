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
            DataSet dataSet = new DataSet();    
        }
    }
}


