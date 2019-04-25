using System;
using System.Text;
using System.Data.SqlClient;

namespace SQLServerTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
                {
                    DataSource = "localhost",
                    UserID = "MSSQLSERVER02",
                    Password = "",
                    InitialCatalog = "master"
                };

                Console.Write("Conectando...");
                using (SqlConnection connection = new SqlConnection("server=DESKTOP-MFRMSRD\\MSSQLSERVER01; database=master; integrated security=true"))
                {
                    connection.Open();
                    Console.WriteLine("Done.");
                    StringBuilder sb = new StringBuilder();
                    String sql;
                    //sb.Append("USE SampleDB;");

                    /*
                    sql = "DROP DATABASE IF EXISTS [SampleBD]; CREATE DATABASE [SampleDB]";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }
                    */
                    /*
                    //sb.Append("CREATE TABLE Cargo(idCargo int not null,nombreCargo char(50))");
                    sb.Append("ALTER TABLE Cargo ADD CONSTRAINT PKCargo PRIMARY KEY(idCargo)");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Done.");
                    }
                    */
                    
                    sb.Append("USE SampleDB;");
                    sb.Append("INSERT Cargo (idCargo, nombreCargo) VALUES (@IdCargo, @NombreCargo)");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCargo", "Programador");
                        command.Parameters.AddWithValue("@IdCargo", 2);
                        int RowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows affected {RowsAffected}");
                        Console.WriteLine("Done.");
                    }
                    sb.Clear();

                    // UPDATE
                    sb.Append("USE SampleDB;");
                    sb.Append("UPDATE Cargo SET nombreCargo = 'Desarrollador' WHERE nombreCargo = @NombreCargo");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCargo", "Programador");
                        int RowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{RowsAffected} instance(s) updated");
                    }
                    sb.Clear();

                    // DELETE 
                    sb.Append("USE SampleDB;");
                    sb.Append("DELETE Cargo WHERE nombreCargo = @NombreCargo");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCargo", "Desarrollador2");
                        int RowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{RowsAffected} instance(s) deleted");
                    }
                    sb.Clear();

                    // SELECT 
                    sb.Append("USE SampleDB;");
                    sb.Append("SELECT idCargo, nombreCargo FROM Cargo;");
                    sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(0)} | {reader.GetString(1)}");
                            }
                        }
                    }
                    

                }

            }
            catch (SqlException e)
            {
                Console.Write(e.ToString());
            }
            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}
