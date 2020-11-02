using System;

namespace _99.Demo4_ShadowingMemners
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tennisEvent = new TennisEvent();
            tennisEvent.Start();
            Console.WriteLine(tennisEvent.Duration);
            
            tennisEvent.Print();
            Console.WriteLine(tennisEvent.Duration);

            Console.WriteLine(tennisEvent.ToString());

            SoftUniList<int> list = new SoftUniList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
