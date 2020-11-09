using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_IsKeyword
{
    class Snake: Animal
    {
        public void EatPerson(Human human)
        {

        }
        public override void Eat(object food)
        {
            if(!(food is Program))
            {
                Console.WriteLine("Аз съм змия и обичам да ям мишки.");
            }
            else
            {
                Console.WriteLine("Днес не съм гладна");
            }
        }
    }
}
