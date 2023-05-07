using System;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person firstPerson = new Person();
            //firstPerson.Name = Console.ReadLine();
            //firstPerson.Age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Name: {firstPerson.Name}; Age: {firstPerson.Age}");

            Person secondPerson = new Person();
            secondPerson.Name = Console.ReadLine();
            secondPerson.Age = int.Parse(Console.ReadLine());
            secondPerson.IntroduceYourself();

        }
    }
}
