using System;
using MySql.Data.MySqlClient;

namespace Lab3_9
{
    class Program
    {
        // Connection string to MySQL database
        static string connectionString = "Server=localhost;Database=c_sharpdikshya;Uid=root;Pwd=;";

        static void Main(string[] args)
        {
            // Create, Read, Update, Delete operations menu
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Insert Data");
            Console.WriteLine("2. Read Data");
            Console.WriteLine("3. Update Data");
            Console.WriteLine("4. Delete Data");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InsertData();
                    break;
                case 2:
                    ReadData();
                    break;
                case 3:
                    UpdateData();
                    break;
                case 4:
                    DeleteData();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Main(args); // Recur to show the menu again
        }

        // Method to insert data into database
        static void InsertData()
        {
            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee address:");
            string address = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO employees (Name, Age, Address) VALUES (@Name, @Age, @Address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Address", address);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully!");
            }
        }

        // Method to read and display data from the database
        static void ReadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Employees";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Address: {reader["Address"]}");
                }
            }
        }

        // Method to update data in the database
        static void UpdateData()
        {
            Console.WriteLine("Enter the ID of the employee to update:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new address:");
            string address = Console.ReadLine();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Employees SET Name = @Name, Age = @Age, Address = @Address WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Address", address);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Data updated successfully!");
            }
        }

        // Method to delete data from the database
        static void DeleteData()
        {
            Console.WriteLine("Enter the ID of the employee to delete:");
            int id = int.Parse(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Employees WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Data deleted successfully!");
            }
        }
    }
}
