using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Exeptions
{
    public static class ExeptionMessage
    {
        public static string NeedRefueling = "{0} needs refueling";

        public static string FuelMustBePositiveNumber = "Fuel must be a positive number";

        public static string ValueMustBePositiveNumber = "Value must be a positive number";

        public static string CannotFitFuelInTheTank = "Cannot fit {0} fuel in the tank";
    }
}
