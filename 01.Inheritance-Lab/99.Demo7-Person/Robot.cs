using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo7_Person
{
    public class Robot: Person
    {
        public override void Sleep()
        {
            throw new ArgumentException("Робота не спи");
        }
    }
}
