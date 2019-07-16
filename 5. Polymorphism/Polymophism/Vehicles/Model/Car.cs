using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Model
{
    public class Car : Vehicle
    {
        private const double INCREASE_FUEL_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsuption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsuption + INCREASE_FUEL_CONSUMPTION;
            this.TankCapacity = tankCapacity;
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }

        public override void Refuel(double refuelingLiters)
        {
            this.FuelQuantity += refuelingLiters;
        }
    }
}
