using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo4_AbstractClass
{
    class Programmer : Worker
    {
        public override int Salary { get; set; } // абстракните пропъртита се override-ват
        public override void Work() // абстракните методи се override-ват
        {
            Console.WriteLine("Днес не работя.");
        }
    }
}
