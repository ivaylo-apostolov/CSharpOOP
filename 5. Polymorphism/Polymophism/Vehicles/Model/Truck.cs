using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles.Model
{
    public class Truck : Vehicle
    {
        private const double INCREASE_FUEL_CONSUMPTION = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (this.FuelConsumption <= this.TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }
            else
            {
                this.FuelQuantity = 0;
            }
            this.FuelConsumption = fuelConsumption + INCREASE_FUEL_CONSUMPTION;
            this.TankCapacity = tankCapacity;
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }

        public override void Refuel(double refuelingLiters)
        {
            double currentAndAddedFuel = this.FuelQuantity + refuelingLiters;

            if (currentAndAddedFuel <= TankCapacity)
            {
                this.FuelQuantity += refuelingLiters * 0.95;
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
