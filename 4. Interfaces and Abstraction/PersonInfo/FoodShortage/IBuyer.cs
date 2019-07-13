using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IBuyer
    {
        int Food { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        void BuyFood();
    }
}
