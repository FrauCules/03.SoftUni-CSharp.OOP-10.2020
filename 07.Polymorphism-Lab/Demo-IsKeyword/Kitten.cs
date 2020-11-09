using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_IsKeyword
{
    class Kitten : Cat
    {
        public override void Sleep()
        {
            Console.WriteLine("Аз съм коте и спя много");
        }

        public override void Eat(object food)
        {
            Console.WriteLine("Аз съм коте и ям малко");
        }
    }
}
