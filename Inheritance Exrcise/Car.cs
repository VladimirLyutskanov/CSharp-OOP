namespace NeedForSpeed
{
    class Car : Vehicle
    {
        public Car(int horsepower, double fuel) : base(horsepower, fuel)
        {
        }

        public override double FuelConsumption => 3;
    }
}
