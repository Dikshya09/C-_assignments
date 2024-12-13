using System;
using MySql.Data.MySqlClient;

namespace Lab3_4
{
    class Program
    {
        // Connection string
        private const string connectionString = "Server=localhost;Database=c_sharpdikshya;User ID=root;Password=;";

        static void Main(string[] args)
        {
            try
            {
                // Edit (Update) operation
                EditStaff(1, "Ram Bahadur", 52000, "Bhaktapur");

                // Delete operation
                DeleteStaff(3);

                // Display remaining staff
                Console.WriteLine("Remaining staff in the database:");
                SelectStaff();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Keep the console open
            Console.ReadLine();  // This will prevent the console from closing immediately
        }

        // Method to edit (update) a staff record
        public static void EditStaff(int id, string name, decimal salary, string address)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL Update Command
                    string query = "UPDATE staff SET name = @Name, salary = @Salary, address = @Address WHERE id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.Parameters.AddWithValue("@Address", address);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Updated {rowsAffected} row(s) in the staff table.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in EditStaff: {ex.Message}");
                }
            }
        }

        // Method to delete a staff record
        public static void DeleteStaff(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL Delete Command
                    string query = "DELETE FROM staff WHERE id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter
                        cmd.Parameters.AddWithValue("@Id", id);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"Deleted {rowsAffected} row(s) from the staff table.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in DeleteStaff: {ex.Message}");
                }
            }
        }

        // Method to select and display all staff
        public static void SelectStaff()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL Select Command
                    string query = "SELECT * FROM staff";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the query and read the results
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Display the data
                            while (reader.Read())
                            {
                                Console.WriteLine($"Id: {reader["id"]}, Name: {reader["name"]}, Salary: {reader["salary"]}, Address: {reader["address"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in SelectStaff: {ex.Message}");
                }
            }
        }
    }
}

