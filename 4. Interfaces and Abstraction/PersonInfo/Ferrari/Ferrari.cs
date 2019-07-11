using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : iCar
    {
        public Ferrari(string driverName)
        {
            this.Model = "488-Spider";
            this.DriverName = driverName;
        }

        public string Model { get ; set ; }
        public string DriverName { get; set; }

        public string Break()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{Break()}/{Gas()}/{this.DriverName}";
        }
    }
}
