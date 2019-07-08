namespace NeedForSpeed.Car
{
    public class SportCar : Car
    {
        private const double DEFAULT_FUEL_CONSUPTION = 10;

        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            
        }

        public override double FuelConsumption => DEFAULT_FUEL_CONSUPTION;
    }
}
