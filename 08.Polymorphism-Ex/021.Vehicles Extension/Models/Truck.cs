using _021.VehiclesExtention.Contracts;
using System;

namespace _021.VehiclesExtention.Models

{
    public class Truck : Vehicle
    {
        private const double SummerAddConsumptions = 1.6;
        private const double ConstantLostFuel = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
           : base(fuelQuantity, fuelConsumption, tankCapacity)
        { }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + SummerAddConsumptions;
            }
        }

        public override void Refuel(double liters)
        {
            if (liters > (TankCapacity-FuelQuantity))
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                base.Refuel(liters * ConstantLostFuel);
            }
        }
    }
}
