using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Animals
{
    class Engine
    {
        private const string End_of_input = "Beast!";
        private readonly List<Animal> animals;
        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string animalTyp;
            while ((animalTyp = Console.ReadLine()) != End_of_input)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Animal animal = GetAnimal(animalTyp,input);
                    this.animals.Add(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
            
            foreach (Animal item in animals)
            {
                Console.WriteLine(item);
            }
        }

        private Animal GetAnimal(string animalTyp, string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string gender = null;

            if (input[2] != null)
            {
                gender = input[2];
            }

            Animal animal = null;

            switch (animalTyp)
            {
                case "Dog":
                    animal = new Dog(name, age, gender);
                    break;
                case "Cat":
                    animal = new Cat(name, age, gender);
                    break;
                case "Frog":
                    animal = new Frog(name, age, gender);
                    break;
                case "Kittens":
                    animal = new Kitten(name, age);
                    break;
                case "Tomcat":
                    animal = new Tomcat(name, age);
                    break;
                default:
                    throw new ArgumentException("Invalid input!");
            }


            return animal;
        }
    }
}
