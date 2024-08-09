using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number =Convert.ToInt32(Console.ReadLine());
           
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            Console.ReadKey();
        }
    }
}
