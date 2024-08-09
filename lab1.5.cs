using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();

            double result=0;
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num2 - num1;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 != 0)
                {
                    result= num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide a number by 0");
                }
            }else { 
                Console.WriteLine("Invalid Operator");
            }
            Console.WriteLine("Result" + result);
            Console.ReadKey();
        }
    }
}
