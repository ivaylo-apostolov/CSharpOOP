using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Model.Animal.Mammal
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }
    }
}
