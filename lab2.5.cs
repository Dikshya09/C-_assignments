using System;

namespace Lab2Q5
{
    class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Cat : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
            Console.ReadKey();
        }
    }

    internal class Lab2  // Updated class name (PascalCase)
    {
       /* static void Main()
        {
            // Create objects of derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call the Speak method
            myDog.Speak();  // Output: The dog barks.
            myCat.Speak();  // Output: The cat meows.
        }*/
    }
}
