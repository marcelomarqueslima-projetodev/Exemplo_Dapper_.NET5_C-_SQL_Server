using Microsoft.Data.SqlClient;
using System;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=DESKTOP-297NQ9F\\SQLEXPRESS;Database=Blog;User ID=sa;Password=mar15l82";

        static void Main(string[] args)
        {
            var Connection = new SqlConnection(CONNECTION_STRING);
            Connection.Open();

            Connection.Close();
            Console.ReadKey();
        }
    }
}
