using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha09
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "MEEOW";
        }
    }
}
