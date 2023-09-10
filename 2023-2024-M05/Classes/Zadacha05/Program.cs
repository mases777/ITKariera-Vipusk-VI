using System;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primer1 = new Scale<int>(32, 41);
            Console.WriteLine(primer1.GetHavier());

            var primer2 = new Scale<string>("Ivan", "Petar");
            Console.WriteLine(primer2.GetHavier());

            var primer3 = new Scale<bool>(true, false);
            Console.WriteLine(primer3.GetHavier());

            var primer4 = new Scale<double>(2.34, 3.14);
            Console.WriteLine(primer4.GetHavier());
        }
    }
}
