using System;
namespace DikshyaShahi_Lab1_
{
    internal class lab1
    {
            static void Main(string[] args)
            {
            string[] strarray = { "Hi!","My","name","is","Dikshya."};
            string result = string.Join(" ", strarray);
            Console.WriteLine($"Converted String array into string :\n{result}");
                Console.ReadKey();
            }
        }
    }

