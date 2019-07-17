using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
