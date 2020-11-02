using System;
using System.Dynamic;

namespace _99.Demo2_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Golf";
            car.Drive(20);
            car.Drive(100);

            Car newCar = car.CreateCar();
        }

        class Car
        {
            public int Miles { get; set; }
            public string Name { get; set; }



            public void Drive(int Miles)
            {
                User.Drive(this);
                this.Miles += Miles;
            }

            public Car CreateCar()
            {
                Miles = 0;
                return this;
            }
        }

        class User
        {
            public static void Drive(Car car)
            {
                car.Miles += 50;
            }
        }
    }

}
