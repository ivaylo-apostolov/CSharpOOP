﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Animals
{
    public class Pig : Animal
    {
        public Pig(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }
    }
}
