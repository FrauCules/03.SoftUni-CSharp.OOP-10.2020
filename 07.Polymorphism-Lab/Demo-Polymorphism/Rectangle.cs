using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Polymorphism
{
    class Rectangle : Shape
    {
        public int A{ get; set; }
        public int B{ get; set; }

        public override double Area()
        {
            return A * B;
        }
    }
}
