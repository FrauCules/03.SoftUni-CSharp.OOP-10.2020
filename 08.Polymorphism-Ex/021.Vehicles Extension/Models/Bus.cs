using System;
using _021.VehiclesExtention.Contracts;

namespace _021.VehiclesExtention.Models
{
    public class Bus : Vehicle
    {
        private const double AddConsumptions = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {}

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + AddConsumptions;
            }
        }

        public override void DriveEmpty(double distance)
        {
            if (FuelQuantity>0)
            {
                double currentQuantity = distance * (this.FuelConsumption-AddConsumptions);
                if (currentQuantity > FuelQuantity)
                {
                    Console.WriteLine($"{this.GetType().Name} needs refueling");
                }
                else
                {
                    FuelQuantity -= currentQuantity;
                    Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                }
            }
        }
    }
}
