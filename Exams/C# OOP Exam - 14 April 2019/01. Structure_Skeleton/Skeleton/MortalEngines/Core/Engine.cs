using MortalEngines.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortalEngines.Core
{
    public class Engine : IEngine
    {
        private IMachinesManager machineManager;

        public Engine()
        {
            this.machineManager = new MachinesManager();
        }

        public void Run()
        {
            var sb = new StringBuilder();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Quit")
            {
                var tokens = input
                    .Split()
                    .ToArray();

                string command = tokens[0];
                string name = tokens[1];

                try
                {
                if (command == "HirePilot")
                {
                    sb.AppendLine(machineManager.HirePilot(name));
                }
                else if (command == "PilotReport")
                {
                    sb.AppendLine(machineManager.PilotReport(name));
                }
                else if (command == "ManufactureTank")
                {
                    double attack = double.Parse(tokens[2]);
                    double defence = double.Parse(tokens[3]);

                    sb.AppendLine(machineManager.ManufactureTank(name, attack, defence));
                }
                else if (command == "ManufactureFighter")
                {
                    double attack = double.Parse(tokens[2]);
                    double defence = double.Parse(tokens[3]);

                    sb.AppendLine(machineManager.ManufactureFighter(name, attack, defence));
                }
                else if (command == "MachineReport")
                {
                    sb.AppendLine(machineManager.MachineReport(name));
                }
                else if (command == "AggressiveMode")
                {
                    sb.AppendLine(machineManager.ToggleFighterAggressiveMode(name));
                }
                else if (command == "DefenseMode")
                {
                    sb.AppendLine(machineManager.ToggleTankDefenseMode(name));
                }
                else if (command == "Engage")
                {
                    string machineName = tokens[2];

                    sb.AppendLine(machineManager.EngageMachine(name, machineName));
                }
                else if (command == "Attack")
                {
                    string defencingMachineName = tokens[2];

                    sb.AppendLine(machineManager.AttackMachines(name, defencingMachineName));
                }
                }
                catch (NullReferenceException nre)
                {
                    sb.AppendLine("Error:" + nre.Message);
                }
                catch (ArgumentNullException ane)
                {
                    sb.AppendLine("Error:" + ane.Message);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
