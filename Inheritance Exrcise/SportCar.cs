namespace NeedForSpeed
{
    class SportCar : Car
    {
        public SportCar(int horsepower, double fuel) : base(horsepower, fuel)
        {

        }

        public override double FuelConsumption => 10;

    }
}
