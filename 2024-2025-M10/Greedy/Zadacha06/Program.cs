

internal class Program
{
    static List<int> currentSolution = new List<int>();
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Solve(n, 0);
    }

    private static void Solve(int n, int index)
    {
        if (n <= 0)
        {
            for (int i = 0; i < currentSolution.Count-1; i++)
            {
                if (currentSolution[i] < currentSolution[i+1])
                {
                    return;
                }
            }
            Console.WriteLine(string.Join(" + ", currentSolution));
            return;
        }
        for (int i = n; i > 0; i--)
        {
            currentSolution.Add(i);
            Solve(n - i, index + 1);
            currentSolution.RemoveAt(index);
        }
    }
}