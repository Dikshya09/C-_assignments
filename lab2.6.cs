using System;
namespace lab2Q6
{       public class ConstructorDemo
        {
            int a, b;
            public ConstructorDemo()
            {
                a = 200;
                b = 300;
                Console.WriteLine("This is Default Constructor");
            }
            public ConstructorDemo(int x, int y)
            {
                a = x;
                b = y;
            }

            public ConstructorDemo(ConstructorDemo cd)
            {
                a = cd.a;
                b = cd.b;
            }

            static ConstructorDemo()
            {
                Console.WriteLine("This is static constructor");
            }
           /* static void Main(string[] args)
            {
                //default
                ConstructorDemo demo = new ConstructorDemo();
                Console.WriteLine(demo.a);
                Console.WriteLine(demo.b);

            //parameterized
            Console.WriteLine("This is parameterized  constructor");
            ConstructorDemo cdemo = new ConstructorDemo(450, 120);
                Console.WriteLine(cdemo.a);
                Console.WriteLine(cdemo.b);
            //copy 
            Console.WriteLine("This is copy  constructor");
            ConstructorDemo cpdemo = new ConstructorDemo(cdemo);
                Console.WriteLine(cpdemo.a);
                Console.WriteLine(cpdemo.b);

                Console.ReadKey();
            }
           */
        }

    }
