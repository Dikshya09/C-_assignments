using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikshyaShahi_Lab1_
{
    internal class lab11
    {
       static void Main(string[] args)
        {
            // Input matrix dimensions
            Console.Write("Enter the number of rows for Matrix A: ");
            int rowsA = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns for Matrix A / rows for Matrix B: ");
            int columnsA = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns for Matrix B: ");
            int columnsB = int.Parse(Console.ReadLine());

            // Initialize matrices
            int[,] matrixA = new int[rowsA, columnsA];
            int[,] matrixB = new int[columnsA, columnsB];
            int[,] resultMatrix = new int[rowsA, columnsB];

            // Input Matrix A
            Console.WriteLine("Enter elements for Matrix A:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    Console.Write($"Element A[{i}, {j}]: ");
                    matrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input Matrix B
            Console.WriteLine("Enter elements for Matrix B:");
            for (int i = 0; i < columnsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    Console.Write($"Element B[{i}, {j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Perform matrix multiplication
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < columnsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            // Display the result
            Console.WriteLine("\nResultant Matrix:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Wait for a key press to exit
            Console.ReadKey();
        }
    }
}
