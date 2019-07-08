using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation
{
    public class PriceCalculator : Stat
    {
        public static decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            decimal disc = (decimal)discount / 100;
            int seasonType = (int)season;

            decimal totalPrice = pricePerDay * numberOfDays * seasonType;
            totalPrice = totalPrice - totalPrice * disc;

            return totalPrice;
        }
    }
}
