using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo_Inhetitance
{
    public class FactoryWorker : Worker
    {
        public void LeaveFactory()
        {
            Console.WriteLine("Leave");
            Console.WriteLine(Name);
        }
    }
}
