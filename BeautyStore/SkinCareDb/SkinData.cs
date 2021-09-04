using System;
using System.Data.SqlClient;
using System.Data;

namespace SkinCareDb
{
    public class SkinData
    {
        public static void GetToner(string conString, out SqlConnection connection, out SqlCommand command)
        {
            string query = "GetToner";
            int i = 1;
            SqlDataReader reader;
            using (connection = new SqlConnection(conString))
            {
                try
                {
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{i}) {reader[0]} - {reader[1]}");
                                i++;
                            }
                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public static void GetCleanser(string conString, out SqlConnection connection, out SqlCommand command)
        {
            string query = "GetCleanser";
            int i = 1;
            SqlDataReader reader;
            using (connection = new SqlConnection(conString))
            {
                try
                {
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{i}) {reader[0]} - {reader[1]}");
                                i++;
                            }
                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        public static void GetMoisturizer(string conString, out SqlConnection connection, out SqlCommand command)
        {
            string query = "GetMoisturizer";
            int i = 1;
            SqlDataReader reader;
            using (connection = new SqlConnection(conString))
            {
                try
                {
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{i}) {reader[0]} - {reader[1]}");
                                i++;
                            }
                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }
        public static void GetMask(string conString, out SqlConnection connection, out SqlCommand command)
        {
            string query = "GetMask";
            int i = 1;
            SqlDataReader reader;
            using (connection = new SqlConnection(conString))
            {
                try
                {
                    using (command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{i}) {reader[0]} - {reader[1]}");
                                i++;
                            }
                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
