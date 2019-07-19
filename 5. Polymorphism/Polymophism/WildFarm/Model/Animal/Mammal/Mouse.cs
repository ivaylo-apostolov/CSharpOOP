using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exeptions;
using WildFarm.Model.Food;

namespace WildFarm.Model.Animal.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
        }
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eating(Food.Food food)
        {
            string foodName = food.GetType().Name;

            if (foodName == "Vegetable" || foodName == "Fruit")
            {
                this.Weight += food.Quantity * 0.1;
                this.FooodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExeptionMessage.AnimalDoesNotEatFood, this.GetType().Name, food.GetType().Name));
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FooodEaten}]";
        }
    }
}
