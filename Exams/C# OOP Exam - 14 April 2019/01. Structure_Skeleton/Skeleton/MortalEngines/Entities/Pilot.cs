using MortalEngines.Common;
using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public class Pilot : IPilot
    {
        private string name;
        private List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Message.PilotNameCannotBeNull);
                }

                this.name = value;
            }
        }

        public IReadOnlyCollection<IMachine> Machines
        {
            get
            {
                return this.machines.AsReadOnly();
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine != null)
            {
                machines.Add(machine);
            }
            else
            {
                throw new NullReferenceException(Message.NullMachineCannotBeAddedToThePilot);
            }
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Name} - {machines.Count} machines");

            foreach (var machine in Machines)
            {
                sb.AppendLine(base.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
