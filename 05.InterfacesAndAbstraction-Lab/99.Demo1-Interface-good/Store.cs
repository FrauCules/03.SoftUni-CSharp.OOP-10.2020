using _99.Demo1_Interface_good_code.Contracts;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace _99.Demo1_Interface_good_code
{
    class Store
    {
        public void BuyProduct(IPrice product, User user)
        {
            decimal price = product.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Нама достатъчно пари");
            }

            user.Money -= price;
            Console.WriteLine($"Bought: {product} + for only: {price}");
        }   
    }
}
