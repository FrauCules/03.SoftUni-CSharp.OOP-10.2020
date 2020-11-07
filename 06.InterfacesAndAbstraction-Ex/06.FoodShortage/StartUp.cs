using _06.FoodShortage.Core;
using System;
using System.Collections.Generic;

namespace _06.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engin = new Engine();
            engin.Run();
        }
    }
}