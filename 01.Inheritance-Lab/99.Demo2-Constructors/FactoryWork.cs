using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo_Inhetitance
{
    public class FactoryWorker : Worker
    {
        public FactoryWorker():base()
        {
            Console.WriteLine("In the empty FactoryWorker constructor");
        }

        public FactoryWorker(string factory) : base("FactoryCompany")
        {
            Console.WriteLine("In the FactoryWorker constructor");
        }
 

        public void LeaveFactory()
        {
            Console.WriteLine("Leave");
            Console.WriteLine(Name);
        }
    }
}
