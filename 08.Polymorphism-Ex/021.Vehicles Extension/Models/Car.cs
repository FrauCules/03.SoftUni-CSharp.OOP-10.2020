using _021.VehiclesExtention.Contracts;

namespace _021.VehiclesExtention.Models
{
    public class Car : Vehicle
    {
        private const double SummerAddConsumptions = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
    }
}
