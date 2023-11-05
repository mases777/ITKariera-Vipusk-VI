using System;

namespace Zadacha15
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Person per = new Person("", "Stephan", 12);
			}
			catch (ArgumentException ex)
			{
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('*', 33));

            try
			{
				Person per = new Person("Stephi", "Stephanov", -12);
			}
			catch (ArgumentException ex)
			{
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('*', 33));

            try
            {
                Person per = new Person("Stephi", "", 25);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
