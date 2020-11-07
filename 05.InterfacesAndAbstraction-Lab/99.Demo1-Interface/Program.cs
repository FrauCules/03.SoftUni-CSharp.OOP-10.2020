using System;

namespace _99.Demo1_Interface_bad
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            User user = new User();
            user.Money = 500;
            store.BuyMicrophone(new Microphone(), user);
            store.BuyToothbrush(new Toothbrush(), user);
            store.BuyShoe(new Shoe(), user);
        }
    }
}
