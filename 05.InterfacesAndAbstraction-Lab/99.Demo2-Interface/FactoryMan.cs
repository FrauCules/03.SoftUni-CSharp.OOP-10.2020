using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo2_Interface
{
    class FactoryMan : IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Can get more");
        }

        public void Work()
        {
            Console.WriteLine("Hussling hard");
        }
    }
}
