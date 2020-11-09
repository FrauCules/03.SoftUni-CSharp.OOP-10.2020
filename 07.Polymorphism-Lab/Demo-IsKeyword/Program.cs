 using System;

namespace Demo_IsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Snake();
            Snake snake = animal as Snake;

            Human human = new Human(animal);
            human.Feed();

            
            // Проверява от кой ти е обекта
            Animal animal1 = new Snake();
            if(animal1 is Snake)
            {
                Console.WriteLine("Аз съм змия");
            }

            if (animal1 is Cat)
            {
                Console.WriteLine("Аз съм котка");
            }

            // Обратна проверка - дали детето принадлежи към някой родител
            Cat cat = new Cat();
            if(cat is Animal)
            {
                Console.WriteLine("Аз съм клас животно");
            }

            Animal animal2 = new Cat();
            Animal animal3 = new Kitten();

            Human catLover = new Human(animal2);
            Human snakeLover = new Human(animal1);

            while (true)
            {
                Console.ReadLine();
                catLover.Feed();
                catLover.PutToSleep();
                snakeLover.Feed(); 
                snakeLover.PutToSleep();
            }
        }
    }
}
