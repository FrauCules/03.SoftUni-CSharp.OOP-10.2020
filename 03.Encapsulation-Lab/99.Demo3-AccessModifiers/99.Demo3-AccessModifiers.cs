using System;
using System.Runtime.InteropServices;

namespace _99.Demo3_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Event ev = new Event();
            ev.internalField = 5;
            ev.publicField = 10;


            
            Console.WriteLine("Hello World!");
        }
    }
    public class Event
    {
        private int privateField=0;         // само в този клас
        protected int protectedField = 0;   // само в този и наследяващите класове
        internal int internalField = 0;     // в този проект
        public int publicField = 0;         // навсякъде
        public class PrivateEvent
        {

        }

        public PrivateEvent PrivateEventInstance { get; set; }
    }

    class TennisEvent : Event
    {
        public void Start()
        {
            this.protectedField = 20;
        }
    }
}
 