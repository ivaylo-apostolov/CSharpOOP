using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Exeptions
{
    public static class ExeptionMessage
    {
        public static string MoneyCannotBeNegative = "Money cannot be negative";

        public static string NameCannotBeEmpty = "Name cannot be empty";

        public static string PersonCannotAffordProduct = "{0} can't afford {1}";      
    }
}
