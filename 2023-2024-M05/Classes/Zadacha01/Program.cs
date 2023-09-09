using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Ivan";
            person1.Age = 15;
            person1.IntroduceYourself();

            Person person2 = new Person();
            person2.Name = Console.ReadLine();
            person2.Age = int.Parse(Console.ReadLine());
            person2.IntroduceYourself();
        }
    }
}
