namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsepower, double fuel) : base(horsepower, fuel)
        {
        }

        public override double FuelConsumption => 8;
    }
}
