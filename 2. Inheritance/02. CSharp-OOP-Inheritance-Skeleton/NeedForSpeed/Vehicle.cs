namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual double FuelConsumption
        {
            get
            {
                return DEFAULT_FUEL_CONSUMPTION;
            }
        }

        public void Drive(double kilometers)
        {
            double consumedFuel = kilometers * FuelConsumption;

            if (consumedFuel <= Fuel)
            {
                Fuel -= consumedFuel;
            }
        }
    }
}
