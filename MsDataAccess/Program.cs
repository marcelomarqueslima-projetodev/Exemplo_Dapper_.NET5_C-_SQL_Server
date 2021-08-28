using Microsoft.Data.SqlClient;
using System;

namespace MsDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=DESKTOP-297NQ9F\\SQLEXPRESS;Database=Blog;User ID=sa;Password=mar15l82";

            var connection = new SqlConnection();

            connection.Open();
            connection.Close();

            Console.WriteLine("Hello World!");
        }
    }
}
