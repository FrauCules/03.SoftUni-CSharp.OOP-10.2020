using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        private string start;
        private string stop;
        public Tesla(string model, string color, int batery)
        {
            Model = model;
            Color = color;
            Batery = batery;
        }

        public string Model { get ; set ; }
        public string Color { get ; set ; }
        public int Batery { get; set; }

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
            return $"{this.Color} Tesla {this.Model} with {this.Batery} Batteries";
        }
    }
}
