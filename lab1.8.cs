using System;
namespace DikshyaShahi_Lab1_
{
    internal class lab8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String");
          string str=Console.ReadLine();
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            Console.WriteLine($"Reversed string: {reversed}");
            Console.ReadKey();
        }
    }
}
