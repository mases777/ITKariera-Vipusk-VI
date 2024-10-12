using System.Numerics;

internal class Program
{
    static int[] sizes;
    static BigInteger counter = 0;
    private static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();
        var length = input[0];
        sizes = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();
        Solve(length);
        Console.WriteLine(counter);
    }

    private static void Solve(int length)
    {
        if (length == 0)
        {
            counter++;
            return;
        }
        else if (length > 0)
        {
            for (int i = 0; i < sizes.Length; i++)
            {
                if (length - sizes[i] >= 0)
                {
                    Solve(length - sizes[i]);
                }
            }
        }
    }
}