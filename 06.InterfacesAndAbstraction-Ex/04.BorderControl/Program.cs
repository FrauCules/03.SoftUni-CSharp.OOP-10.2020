using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IId> ids = new List<IId>();
            string line;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] arg = line.Split();
                if (arg.Length == 3)
                {
                    string name = arg[0];
                    int age = int.Parse(arg[1]);
                    string id = arg[2];
                    IId person = new Cirizens(name, age, id);
                    ids.Add(person);
                }
                else
                {
                    string name = arg[0];
                    string id = arg[1];
                    IId robot = new Robots(name, id);
                    ids.Add(robot);
                }
            }

            string fakeId =Console.ReadLine();

            foreach (var item in ids)
            {
                //Console.WriteLine($"{item.Name} - {item.Age} - {item.Id}");
                if (PrintFakeId(item.Id, fakeId))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }

        private static bool PrintFakeId(string id, string fakeId)
        {
            string endId = id.Substring(id.Length - fakeId.Length, fakeId.Length);
            if (endId == fakeId)
            {
                return true;
            }

            return false;
        }
    }
}
