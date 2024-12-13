using System;

namespace Lab2Q7
{
    // Define the Number class
    public class Number
    {
        public int Value;

        // Constructor to initialize the value
        public Number(int value)
        {
            Value = value;
        }

        // Overload the unary - operator
        public static Number operator -(Number n)
        {
            return new Number(-n.Value);
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine($"Value : {Value}");
        }
    }

    internal class lab2
    {
        /*static void Main()
        {
            // Initialize the number with a positive value
            Number num = new Number(10);

            // Display the original value
            num.Display();

            // Use the overloaded unary - operator
            Number negatedNum = -num;

            // Display the negated value
            negatedNum.Display();
            Console.ReadKey();
        }*/
    }
}
