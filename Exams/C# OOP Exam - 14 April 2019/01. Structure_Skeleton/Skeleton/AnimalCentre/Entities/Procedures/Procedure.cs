using AnimalCentre.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected ICollection<IAnimal> ProcedureHistory;

        protected Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
        }

        public abstract void DoService(IAnimal animal, int procedureTime);

        public string History()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");

            foreach (var animal in ProcedureHistory)
            {
                sb.AppendLine($"    - {animal.Name} - Happiness: {animal.Happiness} - Energy: {animal.Energy}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
