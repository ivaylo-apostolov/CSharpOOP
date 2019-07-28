using AnimalCentre.Common;
using AnimalCentre.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCentre.Entities.Hotel
{
    public class Hotel : IHotel
    {
        private const int Capacity = 10;

        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
        }

        public void Accommodate(IAnimal animal)
        {
            if (animals.Count <= Capacity)
            {
                string name = animal.Name;

                if (!animals.ContainsKey(name))
                {
                    animals[name] = animal;
                }
                else
                {
                    throw new InvalidOperationException(String.Format(OutputMessages.AnimalAlreadyExist, name));
                }
            }
            else
            {
                throw new InvalidOperationException(OutputMessages.NotEnoughCapacity);
            }
        }

        public void Adopt(string animalName, string owner)
        {
            //IAnimal animal = animals.Where(a => a.Key == animalName).FirstOrDefault();
        }
    }
}
