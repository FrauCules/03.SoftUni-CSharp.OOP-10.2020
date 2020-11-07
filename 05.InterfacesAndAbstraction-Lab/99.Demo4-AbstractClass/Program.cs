using System;

namespace _99.Demo4_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Programmer();

            worker.Work();
        }
    }
}
