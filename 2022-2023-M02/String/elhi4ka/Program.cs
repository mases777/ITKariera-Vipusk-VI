using System;

namespace elhi4ka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());
                char ch = '#';
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string(' ', n - i));
                    if (i % 2 == 0) ch = '$';
                    else ch = '#';
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(ch + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
            }            
        }
    }
}
