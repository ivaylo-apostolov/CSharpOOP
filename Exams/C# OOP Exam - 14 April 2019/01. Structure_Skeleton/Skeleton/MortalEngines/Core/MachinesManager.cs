namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilots;
        private List<IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new List<IPilot>();
            this.machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (pilots.All(p => p.Name != name))
            {
                IPilot pilot = new Pilot(name);
                pilots.Add(pilot);
                return string.Format(OutputMessages.PilotHired, name);
            }

            return string.Format(OutputMessages.PilotExists, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (machines.All(m => m.Name != name))
            {
                IMachine tank = new Tank(name, attackPoints, defensePoints);
                machines.Add(tank);
                return string.Format(OutputMessages.TankManufactured, name, tank.AttackPoints, tank.DefensePoints);
            }

            return string.Format(OutputMessages.MachineExists, name);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (machines.All(m => m.Name != name))
            {
                Fighter fighter = new Fighter(name, attackPoints, defensePoints);
                machines.Add(fighter);

                return string.Format(OutputMessages.FighterManufactured, name,
                    fighter.AttackPoints, fighter.DefensePoints, fighter.AggressiveModeString);
            }

            return string.Format(OutputMessages.MachineExists, name);
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            IPilot pilot = pilots.FirstOrDefault(p => p.Name == selectedPilotName);

            if (pilot == null)
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            IMachine machine = machines.FirstOrDefault(m => m.Name == selectedMachineName);

            if (machine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            if (machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            machine.Pilot = pilot;
            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attakingMachine = machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defendingMachine = machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (attakingMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            else if (defendingMachine == null)
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            if (attakingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }
            else if (defendingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attakingMachine.Attack(defendingMachine);
            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            IPilot pilot = pilots.FirstOrDefault(p => p.Name == pilotReporting);

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            IMachine machine = machines.FirstOrDefault(m => m.Name == machineName);
            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            IFighter fighter = (IFighter)machines.FirstOrDefault(f => f.Name == fighterName);

            if (fighter == null)
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            fighter.ToggleAggressiveMode();
            return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            ITank tank = (ITank)machines.FirstOrDefault(t => t.Name == tankName);

            if (tank == null)
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            tank.ToggleDefenseMode();
            return string.Format(OutputMessages.TankOperationSuccessful, tankName);
        }
    }
}