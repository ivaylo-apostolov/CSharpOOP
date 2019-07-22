using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Contracts
{
    public interface IHotel
    {
        void Accommodate(IAnimal animal);

        void Adopt(string animalName, string owner);
    }
}
