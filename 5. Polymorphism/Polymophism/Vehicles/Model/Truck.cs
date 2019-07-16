using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Model
{
    public class Truck : Vehicle
    {
        private const double INCREASE_FUEL_CONSUMPTION = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption + INCREASE_FUEL_CONSUMPTION;
            this.TankCapacity = tankCapacity;
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
