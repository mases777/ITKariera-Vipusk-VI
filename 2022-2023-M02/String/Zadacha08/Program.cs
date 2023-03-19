using System;

namespace Zadacha08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                double avg = 0;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j], 10}");
                    avg += matrix[i, j];
                }
                avg /= cols;
                Console.WriteLine($"{avg, 10}");
            }
            
        }
    }
}
