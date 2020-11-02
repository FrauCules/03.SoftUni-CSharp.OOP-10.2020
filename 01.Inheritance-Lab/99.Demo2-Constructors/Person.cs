using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo_Inhetitance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("In the person constructor");
        }
        public bool Gender { get { return true; }}
        public string  Name { get; set; }
        public int Age { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Sleeping!!");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
