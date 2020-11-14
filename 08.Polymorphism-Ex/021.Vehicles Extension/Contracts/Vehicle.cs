using System;

namespace _021.VehiclesExtention.Contracts
{
    public abstract class Vehicle
    {
        private double tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; protected set; }
        public virtual double FuelConsumption { get; protected set; }
        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (this.FuelQuantity > value)
                {
                    this.FuelQuantity = 0;
                }

                this.tankCapacity = value;


            }
        }

        public virtual void Drive(double distance)
        {
            if (this.FuelQuantity > 0)
            {
                double currentQuantity = distance * this.FuelConsumption;
                if (currentQuantity > FuelQuantity)
                {
                    Console.WriteLine($"{this.GetType().Name} needs refueling");
                }
                else
                {
                    this.FuelQuantity -= currentQuantity;
                    Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                }
            }
        }

        public virtual void DriveEmpty(double distance)
        {}


        public virtual void Refuel(double liters)
        {
            double currentLiters = this.FuelQuantity + liters;
            if (currentLiters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity = currentLiters;
            }
        }
    }
}
