using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Citizen : IBirthable, IId, IBuyer
    {
        private int food = 0;
        public Citizen(string name, int  age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = food;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }

        public string GetName()
        {
            return this.Name;
        }
       
        void IBuyer.BuyFood()
        {
            this.Food += 10; ;
        }
    }
}
