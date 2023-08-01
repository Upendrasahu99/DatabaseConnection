using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=LAPTOP-2GBJGBE8\SQLEXPRESS;Initial Catalog=DatabaseConnection;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection established succesfully!");
                int data1 = 4;
                string data2 = "jjj";
                string insertQuery = "INSERT INTO EnterData(data1, data2) values('" + data1 + "','" + data2 + "')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Data is successfully inserted into table");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

