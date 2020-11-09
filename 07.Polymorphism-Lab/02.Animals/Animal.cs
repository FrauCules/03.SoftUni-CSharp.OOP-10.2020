using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        //private string name;
        //private string favoriteFood;

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavouriteFood}";
        }
    }
}
