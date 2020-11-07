using _06.FoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace _06.FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            this.group = group;
            Food = food;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string group { get; set; }
        public int Food { get; set; }

        public string GetName()
        {
            return this.Name;
        }

        void IBuyer.BuyFood()
        {
            this.Food += 5;
        }
    }
}
