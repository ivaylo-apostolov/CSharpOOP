using System;
using System.Collections.Generic;
using System.Text;

using Vehicles.Model;

namespace Vehicles.Core
{
    public class Engine
    {
        Car car;
        Truck truck;

        public Engine()
        {

        }

        public void Run()
        {
            try
            {
            car = AddCar();
            truck = AddTruck();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputCmd = Console.ReadLine()
                    .Split();

                string command = inputCmd[0];
                string vehicleType = inputCmd[1];
                double val = double.Parse(inputCmd[2]);

                if (vehicleType == "Car")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(car.Drive(val));
                    }
                    else if (command == "Refuel")
                    {
                        car.Refuel(val);
                    }
                }
                else if (vehicleType == "Truck")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(truck.Drive(val));
                    }
                    else if (command == "Refuel")
                    {
                        truck.Refuel(val);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }

        private Truck AddTruck()
        {
            var inputTruck = Console.ReadLine()
                            .Split();

            double fuelQuantity = double.Parse(inputTruck[1]);
            double fuelConsumption = double.Parse(inputTruck[2]);

            Truck truck = new Truck(fuelQuantity, fuelConsumption);

            return truck;
        }

        private Car AddCar()
        {
            var inputCar = Console.ReadLine()
                            .Split();

            double fuelQuantity = double.Parse(inputCar[1]);
            double fuelConsumption = double.Parse(inputCar[2]);

            Car car = new Car(fuelQuantity, fuelConsumption);

            return car;
        }
    }
}
