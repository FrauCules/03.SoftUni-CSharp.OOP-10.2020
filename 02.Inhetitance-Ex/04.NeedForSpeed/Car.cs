using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption // презаписваме проп. с новата дефолт.ст-ст
        {
            get
            {
                return DefaultFuelConsumption;
            }
        }
    }
}
