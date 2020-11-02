using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalTyp;
            //Animals animal;

            while ((animalTyp = Console.ReadLine()) != "Beast!")
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];

                switch (animalTyp)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog.GetType().Name);
                        Console.WriteLine(dog);
                        Console.WriteLine(dog.ProduceSound());
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat.GetType().Name);
                        Console.WriteLine(cat);
                        Console.WriteLine(cat.ProduceSound());
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog.GetType().Name);
                        Console.WriteLine(frog);
                        Console.WriteLine(frog.ProduceSound());
                        break;
                    case "Kittens":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat.GetType().Name);
                        Console.WriteLine(tomcat);
                        Console.WriteLine(tomcat.ProduceSound());
                        break;
                }
            }
        }
    }
}
