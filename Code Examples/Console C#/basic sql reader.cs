using System;
using System.Data.SqlClient;
namespace test_sql_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Customer Key:");
                string n = Console.ReadLine();
                Console.Clear();
                //NOT SQL INJECTION SAFE
                //USE AdventureWorksDWBuild
                CreateCommand("SELECT TOP 1 * FROM DIMCUSTOMER WHERE CUSTOMERKEY = " + n);
                Console.WriteLine("");
            }

            void CreateCommand(string queryString, string connectionString)
            {
                try {
                    using (SqlConnection connection = new SqlConnection(
                               connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        SqlDataReader sdr = command.ExecuteReader();
                        sdr.Read();

                        for (int i = 0; i < sdr.FieldCount; i++) {
                            Console.WriteLine(sdr.GetName(i) + ": " + sdr.GetValue(i));
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);                  
                }
            }
        }
    }
}


