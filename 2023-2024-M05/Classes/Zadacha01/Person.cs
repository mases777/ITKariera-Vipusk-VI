using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha01
{
	class Person
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public void IntroduceYourself()
		{
			Console.WriteLine($"Здравейте! Аз съм {Name} и съм на {Age} години.");
		}
	}
}