using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Contracts
{
    public interface IProcedure
    {
        string History();

        void DoService(IAnimal animal, int procedureTime);
    }
}
