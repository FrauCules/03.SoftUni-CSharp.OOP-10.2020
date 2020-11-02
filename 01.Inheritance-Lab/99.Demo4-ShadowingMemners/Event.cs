using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo4_ShadowingMemners
{
    public class Event
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public void Start()
        {
            Console.WriteLine("Event Starting!!!");
        }
    }
}
