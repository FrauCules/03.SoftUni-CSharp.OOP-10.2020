using _01.Vehicles.Contracts;

namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double SummerAddConsumptions = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
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
    }
}
