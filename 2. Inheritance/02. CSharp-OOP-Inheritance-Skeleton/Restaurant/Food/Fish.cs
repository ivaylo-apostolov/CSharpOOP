﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price, double grams = 22) 
            : base(name, price, grams)
        {
        }
    }
}
