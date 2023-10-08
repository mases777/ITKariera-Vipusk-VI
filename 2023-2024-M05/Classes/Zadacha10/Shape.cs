using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha10
{
    public abstract class Shape
    {
        public abstract double calculatePerimeter();
        public abstract double calculateArea();
        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
