using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _03.ShoppingSpree
{

    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProduct();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = arg[0];
                string productName = arg[1];

                try
                {
                    Person person = this.people.First(p => p.Name == personName);   // взима конкретните обекти от списъците 
                    Product product = this.products.First(p => p.Name == productName);

                    person.BuyProduct(product);

                    //Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ex)    // може да се прихващат различни типове грешки
                {
                    Console.WriteLine(ex.Message);
                }
                //catch (ArgumentException ar)
                //{
                //    Console.WriteLine(ar.Message);
                //}
            }

            // Print output 
            foreach (Person item in this.people)
            {
                Console.WriteLine(item);
            }
        }

        private void AddProduct()
        {
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string productInfo = line[0];
                double price = double.Parse(line[1]);

                Product product = new Product(productInfo, price);
                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                double money = double.Parse(line[1]);

                Person person = new Person(name, money);
                this.people.Add(person);
            }
        }
    }
}
