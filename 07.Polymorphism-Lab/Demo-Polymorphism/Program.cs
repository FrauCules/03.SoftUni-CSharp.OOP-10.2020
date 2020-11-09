using System;

namespace Demo_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle();

            if(shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape; // ако ни трябва определен параметър на Rectangle
                Console.WriteLine(rectangle.A);         // примерно някоя от страните му А или В 
            }

            string input = Console.ReadLine();
            while (true)
            {
                Shape baseClass = null;
                if(input == "square")
                {
                    baseClass = new Square() {A=3 };
                }
                else if ("triangle" == input)
                {
                    // baseClass = new Triangle();
                }
                else
                {
                    baseClass = new Rectangle() { A = 5, B = 6 };
                }

                Console.WriteLine(baseClass.Area());
                input = Console.ReadLine();
            }
        }
    }
}
