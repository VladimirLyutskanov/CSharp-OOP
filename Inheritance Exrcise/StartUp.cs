namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(100, 28);

            Car car = new Car(100, 20);

            RaceMotorcycle racemotor = new RaceMotorcycle(200, 50);

            racemotor.Drive(2);
            System.Console.WriteLine(racemotor.Fuel);

            car.Drive(6);
            System.Console.WriteLine(car.Fuel);

            sportCar.Drive(2);
            System.Console.WriteLine(sportCar.Fuel);

            
       }
    }
}
