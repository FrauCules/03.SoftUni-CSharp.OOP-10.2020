using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo3_BaseKeyword
{
    public class Car: Vihicle
    {
        public void Drive()
        {
            Console.WriteLine($"MaxS peed is: {MaxSpeed}");
        }
    }
}
