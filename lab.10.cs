using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab10
    {   static void Main(string[] args)
        {
            Console.Write("Enter an Alphabet: ");
            string str = Console.ReadLine();
            if (str.Length == 1 && char.IsLetter(str[0])) {
                switch (str[0]) {
                case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"{str} is vowel");
                        break;
                    default:
                        Console.WriteLine($"{str} is a consonant.");
                        break;
                } 
            } else{
                Console.WriteLine("Enter valid alphabet");
            }
            Console.ReadKey();
        }
    }
}
