using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var list = new Queue<Citi>();

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split();

                string type = tokens[0];

                if (type == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    long id = long.Parse(tokens[3]);
                    DateTime birthdayDate = DateTime.Parse(tokens[4]);

                    Citi citizen = new Citi(name, age, id, birthdayDate);
                    list.Enqueue(citizen);
                }
                else if (type == "Robot")
                {
                    string model = tokens[1];
                    long id = long.Parse(tokens[2]);

                    IRobot robot = new Citi(model, id);
                }
                else if (type == "Pet")
                {
                    string name = tokens[1];
                    DateTime birthdayDate = DateTime.Parse(tokens[2]);

                    Citi pet = new Citi(name, birthdayDate);
                    list.Enqueue(pet);
                }
            }
            int yearToCheck = int.Parse(Console.ReadLine());


            while (list.Count > 0)
            {
                DateTime date = list.Dequeue().Birthday;
                int year = date.Year;

                if (year == yearToCheck)
                {
                    string formatted = date.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine(formatted);
                }
            }
        }
    }
}
