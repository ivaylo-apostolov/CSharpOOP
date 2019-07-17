using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Exeptions;

namespace Vehicles.Model
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        private double fuelConsumption;

        private double tankCapacity;

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessage.FuelMustBePositiveNumber);
                }

                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessage.FuelMustBePositiveNumber);
                }

                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExeptionMessage.ValueMustBePositiveNumber);
                }
                this.tankCapacity = value;
            }
        }

        public string Drive(double distance)
        {
            double consumatedLiters = this.FuelConsumption * distance;

            if (consumatedLiters <= this.FuelQuantity && this.TankCapacity > 0)
            {
                this.FuelQuantity -= consumatedLiters;
                return $"{GetType().Name} travelled {distance} km";
            }

            return $"{GetType().Name} needs refueling";
        }

        public virtual void Refuel(double refuelingLiters)
        {            
        }
    }
}
