using System;

namespace MulticastDelegate
{
    // Define a delegate
    public delegate void DisplayMessage(string message);

    class Program
    {
        // Method 1 to attach to delegate
        public static void ShowMessage1(string message)
        {
            Console.WriteLine("Message from ShowMessage1: " + message);
            Console.ReadLine();

        }



        // Method 2 to attach to delegate
        public static void ShowMessage2(string message)
        {
            Console.WriteLine("Message from ShowMessage2: " + message);
            Console.ReadLine();
        }

        // Method 3 to attach to delegate
        public static void ShowMessage3(string message)
        {
            Console.WriteLine("Message from ShowMessage3: " + message);
            Console.ReadLine(); 
        }

        static void Main(string[] args)
        {
            // Create an instance of the delegate
            DisplayMessage displayMessage;

            // Add methods to the delegate (multicast)
            displayMessage = ShowMessage1;
            displayMessage += ShowMessage2;
            displayMessage += ShowMessage3;

            // Invoke the multicast delegate
            Console.WriteLine("Invoking the multicast delegate:");
            displayMessage("Hello, multicast delegates!");

            // Remove one method
            displayMessage -= ShowMessage2;

            // Invoke the delegate again
            Console.WriteLine("\nAfter removing ShowMessage2:");
            displayMessage("Hello again!");
        }
    }
}
