using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo_Inhetitance
{
    public class Worker : Person
    {
        public string Company { get; set; }
        public bool IsLazy { get { return true; }} // по подразбиране е True
    }
}
