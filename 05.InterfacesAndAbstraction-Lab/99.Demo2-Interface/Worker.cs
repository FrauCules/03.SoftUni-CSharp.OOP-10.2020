using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo2_Interface
{
    class Worker: IWorker
    {
        public void EatPizza()
        {
            Console.WriteLine();
        }
        public void Work()
        {
            Console.WriteLine("Slacking all day");
        }
        public void GetSalary()
        {
            Console.WriteLine("Undeserved");
        }

    }
}
