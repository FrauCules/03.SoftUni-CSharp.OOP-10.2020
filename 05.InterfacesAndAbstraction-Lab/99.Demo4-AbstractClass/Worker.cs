using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo4_AbstractClass
{
    abstract class Worker : IWorker
    {
        public abstract int Salary { get; set; }
        public abstract void Work(); // ЗАДЪЛЖИТЕЛНО трябва да се овъррайдне в насл.класове

        public void Slack() // дефолтна имплементация - не е задълж. да се овъррайдне в насл.класове
        {
            Console.WriteLine("Slacking is cool!");
        }

        public abstract void GetSalary(); // наследниците трябва да го имплементират
        
    }
}
