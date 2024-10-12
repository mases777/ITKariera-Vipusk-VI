internal class Program
{
    static List<int> fib = new List<int>();
    private static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int a = 1, b = 1, c = a + b;
        fib.Add(a);
        fib.Add(b);
        fib.Add(c);

        for (int i = 0; i < n - 3; i++)
        {
            a = b;
            b = c;
            c = a + b;
            fib.Add(c);
        }
        Console.WriteLine(string.Join(", ", fib));
    }
}