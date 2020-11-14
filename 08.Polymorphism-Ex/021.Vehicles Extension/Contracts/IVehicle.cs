namespace _021.VehiclesExtention.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity{ get; set; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }
        void Drive(double distanse);
        void Refuel(double liters);
    }
}
