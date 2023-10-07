using System;

namespace Zadacha06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weap();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
