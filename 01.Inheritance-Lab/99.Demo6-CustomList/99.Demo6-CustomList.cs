using System;

namespace _99.Demo6_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftUniList<int> list = new SoftUniList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Get(0));
            Console.WriteLine(list.Get(1));
            Console.WriteLine(list.Get(2));
        }
    }
}
