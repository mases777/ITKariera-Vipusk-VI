using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha10
{
    public sealed class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override double calculatePerimeter()
        {
            return 2.0 * Math.PI * radius;
        }
        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
