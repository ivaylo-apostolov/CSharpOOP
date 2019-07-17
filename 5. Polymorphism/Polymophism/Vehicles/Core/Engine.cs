using System;
using System.Collections.Generic;
using System.Text;

using Vehicles.Model;

namespace Vehicles.Core
{
    public class Engine
    {
        Car car = null;
        Truck truck = null;
        Bus bus = null;

        public Engine()
        {

        }

        public void Run()
        {
            try
            {
                car = AddCar();
                truck = AddTruck();
                bus = AddBus();
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


                try
                {
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
                else if (vehicleType == "Bus")
                {
                    if (command == "Drive")
                    {
                        Console.WriteLine(bus.DriveFullBus(val));
                    }
                    else if (command == "Refuel")
                    {
                        bus.Refuel(val);
                    }
                    else if (command == "DriveEmpty")
                    {
                        Console.WriteLine(bus.Drive(val));
                    }
                }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }

        private Bus AddBus()
        {
            var inputBus = Console.ReadLine()
                            .Split();

            double fuelQuantity = double.Parse(inputBus[1]);
            double fuelConsumption = double.Parse(inputBus[2]);
            double tankCapacity = double.Parse(inputBus[3]);

            Bus bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);

            return bus;
        }

        private Truck AddTruck()
        {
            var inputTruck = Console.ReadLine()
                            .Split();

            double fuelQuantity = double.Parse(inputTruck[1]);
            double fuelConsumption = double.Parse(inputTruck[2]);
            double tankCapacity = double.Parse(inputTruck[3]);

            Truck truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);

            return truck;
        }

        private Car AddCar()
        {
            var inputCar = Console.ReadLine()
                            .Split();

            double fuelQuantity = double.Parse(inputCar[1]);
            double fuelConsumption = double.Parse(inputCar[2]);
            double tankCapacity = double.Parse(inputCar[3]);

            Car car = new Car(fuelQuantity, fuelConsumption, tankCapacity);

            return car;
        }
    }
}
