using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab6
    {
         static void Main(string[] args)
         {
             Console.Write("Enter first number");
             double num1 = Convert.ToDouble(Console.ReadLine());
             Console.Write("Enter second number");
             double num2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nOriginal numbers:\nFirst number: {num1}\nSecond number: {num2}");
             double temp = num1;
             num1 = num2;
             num2 = temp;
            Console.WriteLine($"\nSwapped numbers:\nFirst number: {num1}\nSecond number: {num2}");

             Console.ReadKey();
         }
        
    }
}
