using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo2_Interface
{
    class Boss : IManager, IWorker
    {
        public List<IWorker> Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetSalary()
        {
            Console.WriteLine("a lot");
        }

        public void Work()
        {
            Console.WriteLine("work hard");
        }
    }
}
