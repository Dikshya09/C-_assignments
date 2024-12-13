using System;
namespace DikshyaShahi_Lab1_
{
    internal class Lab7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result;
            for (int i = 1; i <= 10; i++)
            {
                result = num1 * i;
                Console.WriteLine($"{num1} x {i} = {result}");
            }
            Console.ReadKey();
        }
    }
}
