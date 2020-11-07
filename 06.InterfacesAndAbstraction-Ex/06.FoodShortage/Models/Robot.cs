using _06.FoodShortage.Interfaces;

namespace _06.FoodShortage.Models
{
    public class Robot: IId
    {
        public Robot(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
