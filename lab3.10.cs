using System;
using MySql.Data.MySqlClient;

namespace TourismDatabaseApp
{
    class Program
    {
        static string connectionString = "Server=localhost; Database=c_sharpdikshya; Uid=root; Pwd=;";

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== Save Tourism Information ===");

                // Get tourism information from the user
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                Console.Write("Enter Duration (in days): ");
                if (!int.TryParse(Console.ReadLine(), out int duration))
                {
                    Console.WriteLine("Invalid duration. Please enter a valid number.");
                    return;
                }

                DateTime createdDate = DateTime.Now;

                SaveTourismInformation(title, description, duration, createdDate);

                Console.WriteLine("Tourism information saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void SaveTourismInformation(string title, string description, int duration, DateTime createdDate)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) VALUES (@Title, @Description, @Duration, @CreatedDate)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Duration", duration);
                    cmd.Parameters.AddWithValue("@CreatedDate", createdDate);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No data was inserted.");
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                Console.WriteLine("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving information: " + ex.Message);
            }
        }
    }
}
