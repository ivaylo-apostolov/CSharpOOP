using AnimalCentre.Common;
using AnimalCentre.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Animals
{
    public class Animal : IAnimal
    {
        private int happiness;

        private int energy;

        public Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = "Centre";
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public string Name { get; private set; }

        public int Happiness
        {
            get
            {
                return this.happiness;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(OutputMessages.InvalidHappiness);
                }

                this.happiness = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(OutputMessages.InvalidEnergy);
                }

                this.energy = value;
            }
        }

        public int ProcedureTime { get;}

        public string Owner { get; set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }

        public override string ToString()
        {
            return $"    Animal type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }

    }
}
