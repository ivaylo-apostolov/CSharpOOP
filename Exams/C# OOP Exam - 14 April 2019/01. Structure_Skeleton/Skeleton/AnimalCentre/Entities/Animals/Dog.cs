﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }


    }
}
