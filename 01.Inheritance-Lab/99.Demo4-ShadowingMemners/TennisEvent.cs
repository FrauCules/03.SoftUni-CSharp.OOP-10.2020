using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _99.Demo4_ShadowingMemners
{
    public class TennisEvent: Event
    {
        public DateTime Duration { get; set; } // скрива Event.Duration 

        public void Start() // не се ползва така, но е възможно да се срещне
        {
            Console.WriteLine("Zagryavka"); // скриваме Event.Start();
            base.Start();   // викаме стария Event.Start();
        }


        public void Print() // НЕ Е препоръчителн ода се припокриват имена
        {
            //Duration = DateTime.Now;
            string Duration = "X";  // можем да дефинираме друг тип със същото име
            Duration = "X";
            this.Duration = DateTime.Now;
            base.Duration = 5;
        }

        public override string ToString()
        {
            return base.ToString() + " Teniiiisssss!!!";
        }
    }
}
