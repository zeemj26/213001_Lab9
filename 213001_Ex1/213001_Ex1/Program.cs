using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq.Expressions;
namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-46PNOSO\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True";
            string queryString = "Select ProductID,UnitPrice,ProductName from Product" + "WHARE UnitPrice > 1000"
                                    + "ORDER BY UnitPrice DESC";
            int paramValue = 5;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(queryString,connection);
            sqlCommand.Parameters.AddWithValue("@pricePoint", paramValue);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                Console.ReadLine();
            }
        }
    }



