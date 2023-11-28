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
            string queryString = "SELECT ProductID, UnitPrice, ProductName from Products" + " WHERE UnitPrice>330" + " Order By UnitPrice  DESC";

            int paramValue = 5;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
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

