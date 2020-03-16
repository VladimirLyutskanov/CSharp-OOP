namespace NeedForSpeed
{
    class Vehicle
    {
        public Vehicle(int horsepower, double fuel)
        {
            this.HorsePower = horsepower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption => 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometers)
        {
            double needeFuel = kilometers * this.FuelConsumption;

            if (this.Fuel >= needeFuel)
            {
                this.Fuel -= needeFuel;
            }
        }


    }
}
