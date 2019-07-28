using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        private const double INITIAL_HEALTH_POINTS = 100;
        private const double CHANGE_ATTACK_POINTS = 40;
        private const double CHANGE_DEFENCE_POINTS = 30;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name,
                  attackPoints - CHANGE_ATTACK_POINTS,
                  defensePoints + CHANGE_DEFENCE_POINTS,
                  INITIAL_HEALTH_POINTS)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (DefenseMode)
            {
                DefenseMode = false;
                DefensePoints -= CHANGE_DEFENCE_POINTS;
                AttackPoints += CHANGE_ATTACK_POINTS;
            }
            else
            {
                DefenseMode = true;
                DefensePoints += CHANGE_DEFENCE_POINTS;
                AttackPoints -= CHANGE_ATTACK_POINTS;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if (DefenseMode)
            {
                sb.AppendLine(" *Defense: ON");
            }
            else
            {
                sb.AppendLine(" *Defense: OFF");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
