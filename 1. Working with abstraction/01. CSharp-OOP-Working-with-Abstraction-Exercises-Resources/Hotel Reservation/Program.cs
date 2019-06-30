using System;

namespace Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split();

            Season season = Season.Autumn;

            if (tokens[2] == "Summer")
            {
                season = Season.Summer;
            }
            else if (tokens[2] == "Autumn")
            {
                season = Season.Summer;
            }

            Console.WriteLine(PriceCalculator.CalculatePrice(decimal.Parse(tokens[0]), int.Parse(tokens[1]), season, tokens[3]); 
        }
    }
}
