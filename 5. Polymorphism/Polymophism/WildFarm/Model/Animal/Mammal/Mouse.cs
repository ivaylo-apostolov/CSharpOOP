using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
