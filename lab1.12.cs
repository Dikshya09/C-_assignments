using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab12
    {
            static void Main(string[] args)
            {
                Console.Write("Enter the number of marks: ");
                int numberOfMarks = int.Parse(Console.ReadLine());

                int[] marks = new int[numberOfMarks];

                // Input marks from the user
                for (int i = 0; i < numberOfMarks; i++)
                {
                    Console.Write($"Enter mark {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());
                }

                // Calculate minimum, maximum, and average marks
                int minMark = marks[0];
                int maxMark = marks[0];
                int totalMarks = 0;

                for (int i = 0; i < numberOfMarks; i++)
                {
                    if (marks[i] < minMark)
                    {
                        minMark = marks[i];
                    }
                    if (marks[i] > maxMark)
                    {
                        maxMark = marks[i];
                    }
                    totalMarks += marks[i];
                }

                double averageMark = (double)totalMarks / numberOfMarks;

                // Display the results
                Console.WriteLine($"\nMinimum Mark: {minMark}");
                Console.WriteLine($"Maximum Mark: {maxMark}");
                Console.WriteLine($"Average Mark: {averageMark:F2}");

                // Wait for a key press to exit
                Console.ReadKey();
            }
        }
    }


