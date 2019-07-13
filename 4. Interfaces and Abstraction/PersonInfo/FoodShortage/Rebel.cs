using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : AbstractCitizen, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Group { get; set; }

        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
