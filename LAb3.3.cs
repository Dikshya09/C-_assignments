using System;
using MySql.Data.MySqlClient;

namespace MySQLDatabaseOperations
{
    class Program
    {
        // Connection string (leave password empty)
        private const string connectionString = "Server=localhost;Database=c_sharpdikshya;User ID=root;Password=;";

        static void Main(string[] args)
        {
            // Check if database and table exist, then insert and select students
            
            InsertStudent("Ram", 20, "Kathmandu");
            InsertStudent("Shyam", 22, "Pokhara");
            InsertStudent("Hari", 19, "Lalitpur");

            // Select and display all students
            Console.WriteLine("\nStudents in the database:");
            SelectStudents();

            // Wait for user input to prevent immediate closing of the console
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        // Method to create Students table if not exists
       
        // Method to insert a student
        public static void InsertStudent(string name, int age, string address)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL Insert Command
                    string query = "INSERT INTO Students (Name, Age, Address) VALUES (@Name, @Age, @Address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Address", address);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Inserted {rowsAffected} row(s) into the Students table.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Method to select and display all students
        public static void SelectStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL Select Command
                    string query = "SELECT * FROM Students";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the query and read the results
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Display the data
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Address: {reader["Address"]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No students found.");
                            }
                        }
                    }
                }
                catch (Exception ex)



                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
