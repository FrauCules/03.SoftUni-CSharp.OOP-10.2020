namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(200,100);
            car.Drive(25);

            SportCar sportCar = new SportCar(200,20);
            sportCar.Drive(30);
        }
    }
}
