
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq.Expressions;

namespace Lab8_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello, World!");
            string connectionString = "Data Source=DESKTOP-30389UE;Initial Catalog=Product;Integrated Security=True;Encrypt=False";
            string queryString = "SELECT CustomerID, CompanyName from Customers";
            //   int paramValue = 5;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            //command.Parameters.AddWithValue("@pricePoint", paramValue);
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
            DataSet customers = new DataSet();
            adapter.Fill(customers, "Customers");
          
        }

    }
}


