using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo1_Interface
{
    class Store
    {
        public void BuyShoe(Shoe shoe, User user)
        {
            decimal price = shoe.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Нама достатъчно пари");
            }

            user.Money -= price;
        }

        public void BuyToothbrush(Toothbrush toothbrush, User user)
        {
            decimal price = toothbrush.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Нама достатъчно пари");
            }

            user.Money -= price;
        }

        public void BuyMicrophone(Microphone mic, User user)
        {
            decimal price = mic.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Нама достатъчно пари");
            }

            user.Money -= price;
        }
    }
}
