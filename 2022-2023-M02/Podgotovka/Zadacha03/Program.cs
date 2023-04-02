using System;

namespace Zadacha03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxWord = "";
            int maxScore = 0;
            string input;
            while ((input = Console.ReadLine()) != "END OF GAME")
            {
                int sum = 0;
                if (input[input.Length - 1] == 'a') sum += 10;
                if (input[input.Length - 1] == 'v') sum += 13;
                if (input.Length >= 7) sum += 33;
                else sum += 22;

                if (sum > maxScore)
                {
                    maxScore = sum;
                    maxWord = input;
                }
            }
            Console.WriteLine($"Winner is name: {maxWord}");
            Console.WriteLine($"Points: {maxScore}");
        }
    }
}
