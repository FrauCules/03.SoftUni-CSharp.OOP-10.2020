using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo_Inhetitance
{
    public class Worker : Person
    {
        public Worker()
        {
            Console.WriteLine("In the empty worker constructor");
        }
        public Worker(string compayName)
        {
            Company = compayName;
            Console.WriteLine("In the worker constructor");
        }

        public string Company { get; set; }
        public bool IsLazy { get { return true; }} // по подразбиране да е True
    }
}
 