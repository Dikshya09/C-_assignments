//using System;

//namespace LAb3_6
//{
//    // Custom Exception class
//    public class AgeException : Exception
//    {
//        public int InvalidAge { get; }

//        // Constructor that accepts a custom message and the invalid age
//        public AgeException(string message, int invalidAge) : base(message)
//        {
//            InvalidAge = invalidAge;
//        }

//        // Constructor that accepts just the invalid age, with a default message
//        public AgeException(int invalidAge) : base($"Invalid age: {invalidAge}. Age must be between 0 and 120.")
//        {
//            InvalidAge = invalidAge;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                // Get the age input from the user
//                Console.WriteLine("Enter your age: ");
//                int age = int.Parse(Console.ReadLine());

//                // Check if the age is valid
//                if (age < 0 || age > 120)
//                {
//                    // Throw custom exception if age is invalid
//                    throw new AgeException(age);
//                }

//                Console.WriteLine($"Your age is: {age}");
//            }
//            catch (AgeException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//                Console.WriteLine($"Invalid age entered: {ex.InvalidAge}");
//            }
//            catch (FormatException ex)
//            {
//                Console.WriteLine("Error: Please enter a valid integer.");
//                Console.ReadLine();

//            }
//            finally
//            {
//                Console.WriteLine("Execution of the program has ended.");
//                Console.ReadLine();
//            }
//        }
//    }
//}
using System;
namespace LAb3_6
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a positive number: ");
                int number = int.Parse(Console.ReadLine());

                // Check for invalid input
                if (number < 0)
                {
                    throw new CustomException("Negative numbers are not allowed.");
                }

                Console.WriteLine($"You entered: {number}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Caught a custom exception: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught a FormatException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution completed.");
                Console.ReadLine();
            }
        }
    }
}
