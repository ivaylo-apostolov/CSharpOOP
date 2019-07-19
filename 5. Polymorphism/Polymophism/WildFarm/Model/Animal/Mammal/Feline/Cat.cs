using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Exeptions;
using WildFarm.Model.Food;

namespace WildFarm.Model.Animal.Mammal.Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
            this.Breed = breed;
        }
        public override string ProduceSound()
        {
            return "Meow";
        }

        public override void Eating(Food.Food food)
        {
            string foodName = food.GetType().Name;

            if (foodName == "Meat" || foodName == "Vegetable")
            {
                this.Weight += food.Quantity * 0.3;
                this.FooodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException(String.Format(ExeptionMessage.AnimalDoesNotEatFood, this.GetType().Name, food.GetType().Name));
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FooodEaten}]";
        }
    }
}
