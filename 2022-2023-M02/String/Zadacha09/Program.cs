using System;
using System.Linq;

namespace Zadacha09
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
                var line = Console.ReadLine()
                        .Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int[] min = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                min[j] = matrix[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i,j] < min[j])
                        min[j] = matrix[i,j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{min[j],5}");
            }
            Console.WriteLine();
        }
    }
}
