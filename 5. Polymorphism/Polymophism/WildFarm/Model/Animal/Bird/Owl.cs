using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exeptions;
using WildFarm.Model.Food;

namespace WildFarm.Model.Animal.Bird
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void Eating(Food.Food food)
        {
            string foodName = food.GetType().Name;

            if (foodName == "Meat")
            {
                this.Weight += food.Quantity * 0.25;
                this.FooodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExeptionMessage.AnimalDoesNotEatFood, this.GetType().Name, food.GetType().Name));
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FooodEaten}]";
        }
    }
}
