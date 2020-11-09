using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2* Height + 2* Width;
        }
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
