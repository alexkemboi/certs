using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        // Connection string
        string connectionString = "server=localhost;user=root;database=clinicaleducationtrackingsystem;port=3306;password=4127";

        // SQL query
        string query = "SELECT * FROM users";

        // Create MySQL connection
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // Create command and assign the query and connection
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // Execute the query and get the data reader
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Loop through the result set
                    while (reader.Read())
                    {
                        // Access the columns by index or name
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("firstName");
                        // Add more columns as needed

                        // Do something with the retrieved data
                        Console.WriteLine($"ID: {id}, Name: {name}");
                    }
                }
            }
        }
    }
}
