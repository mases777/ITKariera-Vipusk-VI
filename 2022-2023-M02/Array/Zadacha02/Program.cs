using System;
using System.Linq;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] count = new int[65535];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            int maxValue = count[0];
            int maxIndex = 0, maxLeft = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > maxValue)
                {
                    maxValue = count[i];
                    maxIndex = i;
                }
                if (maxIndex > maxLeft)
                {
                    maxLeft = maxIndex;
                }
            }
            Console.WriteLine(maxLeft);
        }
    }
}
