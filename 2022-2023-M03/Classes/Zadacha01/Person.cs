using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha01
{
    class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, my name is {Name} and i am {Age} years old.");
        }


    }
}
