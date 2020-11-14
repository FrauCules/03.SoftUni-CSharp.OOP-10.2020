using _01.Vehicles.Contracts;

namespace _01.Vehicles.Models

{
    public class Truck : Vehicle
    {
        private const double SummerAddConsumptions = 1.6;
        private const double ConstantLostFuel = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
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
            base.Refuel(liters * ConstantLostFuel);
        }
    }
}
