using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private int age;
        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public virtual int Age  // value идва от от входното age и после през конструктора  
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public string Gender { get; set; }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{Name} {Age} {Gender}";
        }
    }
}
