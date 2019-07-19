using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Model.Food;

namespace WildFarm.Model.Animal.Bird
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }
        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override void Eating(Food.Food food)
        {
            this.Weight += food.Quantity * 0.35;
            FooodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FooodEaten}]";
        }
    }
}
