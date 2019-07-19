using System;
using System.Collections.Generic;
using System.Text;

using WildFarm.Model.Food;

namespace WildFarm.Model.Animal
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public int FooodEaten { get; set; }

        public abstract string ProduceSound();

        public abstract void Eating(Food.Food food);
        
    }
}
