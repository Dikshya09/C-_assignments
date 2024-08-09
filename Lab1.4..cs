using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class Lab4
    {
        static void Main(string[] args)
        {
            // Prompt user for principal amount
            Console.Write("Enter the principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            // Prompt user for time period in years
            Console.Write("Enter the time period (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            // Prompt user for rate of interest per annum
            Console.Write("Enter the rate of interest per annum (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            // Calculate simple interest
            double simpleInterest = (principal * time * rate) / 100;

            // Display the calculated simple interest
            Console.WriteLine($"\nSimple Interest = {simpleInterest}");

            // Wait for a key press to exit
            Console.ReadKey();
        }
    }
}
