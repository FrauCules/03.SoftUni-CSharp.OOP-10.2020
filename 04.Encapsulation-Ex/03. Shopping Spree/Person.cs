using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, double money) : this()
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }
        public double Money 
        {
            get
            {
                return this.money;
            }
            private set 

            {
                if (value < 0)
                {
                    //throw new ArgumentException("Money cannot be negative");
                    Console.WriteLine("Money cannot be negative");
                    return;
                }

                this.money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag
            => this.bag.AsReadOnly();

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Cost;
            this.bag.Add(product);
            Console.WriteLine($"{this.Name} bought {product}");
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0 ?
                String.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}
