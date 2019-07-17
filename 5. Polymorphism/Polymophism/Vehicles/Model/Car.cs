using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles.Model
{
    public class Car : Vehicle
    {
        private const double INCREASE_FUEL_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsuption, double tankCapacity)
        {            
            if (this.FuelConsumption <= this.TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }
            else
            {
                this.FuelQuantity = 0;
            }
            this.FuelConsumption = fuelConsuption + INCREASE_FUEL_CONSUMPTION;
            this.TankCapacity = tankCapacity;
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }

        public override void Refuel(double refuelingLiters)
        {

            double currentAndAddedFuel = this.FuelQuantity + refuelingLiters;

            if (currentAndAddedFuel <= TankCapacity)
            {
                this.FuelQuantity += refuelingLiters;
            }
            else if (currentAndAddedFuel > TankCapacity)
            {
                throw new ArgumentException(String.Format(ExeptionMessage.CannotFitFuelInTheTank, refuelingLiters));
            }
            else if (refuelingLiters <= 0)
            {
                throw new ArgumentException(ExeptionMessage.FuelMustBePositiveNumber);
            }
        }
    }
}
