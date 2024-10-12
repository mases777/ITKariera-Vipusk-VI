class Program
{
    private static void Main(string[] args)
    {
        var cities = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();
        int n = cities.Length;

        int[] minFuel = new int[n];
        minFuel[0] = cities[0];  //0 - 3
        minFuel[1] = cities[1];  //1 - 101

        for (int i = 2; i < n; i++)
        {
            minFuel[i] = cities[i] + Math.Min(minFuel[i - 1], minFuel[i - 2]);

            //2 - 3+3=6
            //3 - 3+6=9
            //4 - 3+6=9
            //5 - 101+9=110
            //6 - 3+9=12
        }
        int result = Math.Min(minFuel[n - 1], minFuel[n - 2]);
        Console.WriteLine(result);

    }
}