using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new Queue<IBuyer>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                .Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                if (tokens.Length == 4)
                {
                    long id = long.Parse(tokens[2]);
                    DateTime date = DateTime.Parse(tokens[3]);

                    IBuyer buyer = new Citizen(name, age, id, date);
                    list.Enqueue(buyer);
                }
                else if (tokens.Length == 3)
                {
                    string group = tokens[2];

                    IBuyer buyer = new Rebel(name, age, group);
                    list.Enqueue(buyer);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var buyer in list)
                {
                    if (buyer.Name == input)
                    {
                        buyer.BuyFood();
                    }
                }
            }


            int totalFood = 0;

            foreach (var buyer in list)
            {
                totalFood += buyer.Food;
            }
            Console.WriteLine(totalFood);
        }
    }
}
