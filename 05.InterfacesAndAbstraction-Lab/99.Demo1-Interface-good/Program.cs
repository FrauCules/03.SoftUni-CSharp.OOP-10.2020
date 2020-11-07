using System;

namespace _99.Demo1_Interface_good_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            User user = new User();
            user.Money = 500;
            var shoe = new Shoe() { Price = 250 };
            store.BuyProduct(shoe, user);
            store.BuyProduct(new Microphone() { Price =236 }, user);
            store.BuyProduct(new Toothbrush() { Price = 15 }, user);
        }
    }
}
