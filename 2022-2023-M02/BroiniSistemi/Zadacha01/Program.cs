using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1234 -> в двоично
            
            string result = "";

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                result += (n % 2);
                n /= 2;
            }

            string temp = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                temp += result[i];
            }
            Console.WriteLine(result);
            Console.WriteLine(temp);

        }
    }
}
