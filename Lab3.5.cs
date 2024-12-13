using System;

namespace Lab3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                // This line may throw a DivideByZeroException
                int result = numerator / denominator;

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution of the program has ended.");
                Console.ReadLine();
            }
        }
    }
}
