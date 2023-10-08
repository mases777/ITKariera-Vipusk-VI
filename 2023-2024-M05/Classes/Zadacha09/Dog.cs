using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha09
{
    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "DJAAF";
        }
    }
}
