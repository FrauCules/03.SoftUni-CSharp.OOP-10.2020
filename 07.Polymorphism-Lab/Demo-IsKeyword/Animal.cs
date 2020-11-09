using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_IsKeyword
{
    class Animal
    {
        public virtual void Eat(object food)
        {
            Console.WriteLine("Храня се редовно");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Спя по 8 часа");
        }
    }
}
