using System;

namespace DikshyaShahi_Lab1_
{
    internal class lab4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rate of interest per annum (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * time * rate) / 100;

            Console.WriteLine($"\nSimple Interest = {simpleInterest}");

            Console.ReadKey();
        }
    }
}
