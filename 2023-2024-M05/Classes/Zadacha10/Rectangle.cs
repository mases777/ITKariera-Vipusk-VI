using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha10
{
    public sealed class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double calculateArea()
        {
            return this.width * this.height;
        }
        public override double calculatePerimeter()
        {
            return (this.width + this.height) * 2.0;
        }
        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
