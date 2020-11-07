using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get ; set; }
        public string Color { get ; set ; }
        

        string ICar.Start()
        {
            return "Engine start";
        }

        string ICar.Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}";
        }
    }
}
