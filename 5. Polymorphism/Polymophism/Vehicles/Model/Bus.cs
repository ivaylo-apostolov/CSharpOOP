using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Model
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsuption, double tankCapacity)
        {
            if (this.FuelConsumption <= this.TankCapacity)
            {
                this.FuelQuantity = fuelQuantity;
            }
            else
            {
                this.FuelQuantity = 0;
            }
            this.FuelConsumption = fuelConsuption;
            this.TankCapacity = tankCapacity;
        }

        public string DriveFullBus(double distance)
        {
            double consumatedLiters = (this.FuelConsumption + 1.4) * distance;

            if (consumatedLiters <= this.FuelQuantity && this.TankCapacity > 0)
            {
                this.FuelQuantity -= consumatedLiters;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }
    }
}
