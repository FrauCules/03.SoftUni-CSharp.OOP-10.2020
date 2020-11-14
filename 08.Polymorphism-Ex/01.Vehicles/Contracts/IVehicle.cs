namespace _01.Vehicles.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity{ get; }
        public double FuelConsumption { get; }
        void Drive(double distanse);
        void Refuel(double liters);
    }
}
