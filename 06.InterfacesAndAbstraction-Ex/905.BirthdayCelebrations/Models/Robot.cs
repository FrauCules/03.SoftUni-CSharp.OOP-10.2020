using _905.BirthdayCelebrations.Interfaces;

namespace _905.BirthdayCelebrations.Models
{
    public class Robot : IId
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
