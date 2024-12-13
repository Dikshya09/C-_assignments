using System;
namespace Lab2Q8 { 
class Number
{
    public int Value { get; set; }

    // Constructor to initialize the value
    public Number(int value)
    {
        Value = value;
    }

    // Overload the + operator
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.Value + n2.Value);
    }

    // Display method
    public void Display()
    {
        Console.WriteLine("Value: " + Value);
            Console.ReadKey();
    }
}

class Program
{
    /*static void Main(string[] args)
    {
        // Create two Number objects
        Number num1 = new Number(5);
        Number num2 = new Number(10);

        // Add them using the overloaded + operator
        Number result = num1 + num2;

        // Display the result
        result.Display();  // Output: Value: 15
    }*/
}
}
