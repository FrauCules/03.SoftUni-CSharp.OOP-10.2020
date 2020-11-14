using _021.VehiclesExtention.Contracts;
using _021.VehiclesExtention.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _021.VehiclesExtention.Core
{
    public class Engine: IEngine
    {
        protected List<Vehicle> list = new List<Vehicle>();
        public void Run()
        {
            AddVehicles();
            Operations();
            PrintResult();
        }

        private void PrintResult()
        {
            foreach (Vehicle item in list)
            {
                Console.WriteLine($"{item.GetType().Name}: {item.FuelQuantity:f2}");
            }
        }

        private void Operations()
        {
            Vehicle currentVehicle = null;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string operation = input[0];
                string typeVehicle = input[1];
                double argument3 = double.Parse(input[2]);
                currentVehicle = list.First(x => x.GetType().Name == typeVehicle);
                if (argument3 <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    if (operation == "Drive")
                    {
                        currentVehicle.Drive(argument3);
                    }
                    if (operation == "DriveEmpty")
                    {
                        currentVehicle.DriveEmpty(argument3);
                    }
                    else if (operation == "Refuel")
                    {
                        currentVehicle.Refuel(argument3);
                    }
                }
            }
        }

        public void AddVehicles()
        {
            
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                double liters = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                double tankCapacity = double.Parse(input[3]);

                if (type == "Car")
                {
                    Vehicle newVehicle = new Car(liters, fuelConsumption, tankCapacity);
                    list.Add(newVehicle);
                }
                else if(type == "Truck")
                {
                    Vehicle newVehicle = new Truck(liters, fuelConsumption, tankCapacity);
                    list.Add(newVehicle);
                }
                else if (type == "Bus")
                {
                    Vehicle newVehicle = new Bus(liters, fuelConsumption, tankCapacity);
                    list.Add(newVehicle);
                }
            }
        }
    }
}
