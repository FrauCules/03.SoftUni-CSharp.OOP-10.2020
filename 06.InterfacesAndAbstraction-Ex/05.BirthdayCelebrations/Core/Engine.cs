using System;
using System.Collections.Generic;
using _05.BirthdayCelebrations.Interfaces;
using _05.BirthdayCelebrations.Models;
using System.Text;

namespace _05.BirthdayCelebrations.Core
{
    public class Engine : IEngine
    {
        List<IBirthable> birthdays = new List<IBirthable>();

        public void Run()
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] arg = line.Split();
                if (arg[0] == "Citizen")
                {
                    string name = arg[1];
                    int age = int.Parse(arg[2]);
                    string id = arg[3];
                    string birthdate = arg[4];
                    IBirthable person = new Citizen(name, age, id, birthdate);
                    birthdays.Add(person);
                }
                else if (arg[0] == "Pet")
                {
                    string name = arg[1];
                    string birthdate = arg[2];
                    IBirthable pet = new Pet(name, birthdate);
                    birthdays.Add(pet);
                }
            }

            string year = Console.ReadLine();

            foreach (var item in birthdays)
            {
                if (item.Birthdate.EndsWith(year)) // ако р.ден завършва с търсената година
                {
                    Console.WriteLine(item.Birthdate);
                }
            }
        }
    }
}
