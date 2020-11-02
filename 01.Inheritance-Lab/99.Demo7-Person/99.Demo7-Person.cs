using System;

namespace _99.Demo7_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Sleep();

            Person person1 = new Child();
            person1.Sleep();

            Person person2 = new Robot();
            person2.Sleep();   
        }
    }
}
