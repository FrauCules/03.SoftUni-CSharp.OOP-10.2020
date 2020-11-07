using System;
using System.Collections.Generic;
using _06.FoodShortage.Interfaces;
using _06.FoodShortage.Models;
using System.Text;
using System.Linq;

namespace _06.FoodShortage.Core
{
    public class Engine : IEngine
    {
        List<IBuyer> buyers = new List<IBuyer>();
        HashSet<string> names = new HashSet<string>(); 

       
        public void Run()
        {
            AddPerson();
            TakeFood(buyers);
            PrintResult();
        }

        private void PrintResult()
        {
            int foodSum = 0;
            foreach (var buyer in buyers)
            {
                foodSum += buyer.Food;
            }
            Console.WriteLine(foodSum);
        }

        private void AddPerson()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();
                string name = arg[0];
                IBuyer currentBuyer = buyers.FirstOrDefault(x => x.Name == name);
                if(currentBuyer != null)
                {
                    continue;
                }
                else
                {
                    names.Add(name);
                }

                int age = int.Parse(arg[1]);

                if (arg.Length==4)
                {
                    string id = arg[2];
                    string birthdate = arg[3];
                    IBuyer person = new Citizen(name, age, id, birthdate);
                    buyers.Add(person);
                }
                else if (arg.Length == 3)
                {
                    string group = arg[1];
                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }
        }

        public void TakeFood(List<IBuyer> buyers)
        {
            string buyer;
            while ((buyer = Console.ReadLine()) != "End")
            {
                IBuyer currentBuyer = buyers.FirstOrDefault(x => x.Name == buyer);
                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }
            }
        }
    }
}
