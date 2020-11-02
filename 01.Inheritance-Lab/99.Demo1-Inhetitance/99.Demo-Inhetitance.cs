using System;

namespace _99.Demo_Inhetitance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            
            FactoryWorker factoryWorker = new FactoryWorker();

            factoryWorker.Name = "Pesho";
            Console.WriteLine(factoryWorker.Name);
            factoryWorker.Sleep();
            factoryWorker.LeaveFactory();

            Student student = new Student();
            student.Eat();
            Console.WriteLine(factoryWorker.Gender);
        }
    }
}
