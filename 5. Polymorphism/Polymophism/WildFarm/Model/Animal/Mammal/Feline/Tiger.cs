﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal.Mammal.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
            this.Breed = breed;
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}