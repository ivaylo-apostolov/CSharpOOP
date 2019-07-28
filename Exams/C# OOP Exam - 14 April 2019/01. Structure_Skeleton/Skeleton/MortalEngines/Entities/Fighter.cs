using MortalEngines.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private const double CHANGE_ATTACK_POINTS = 50.0;
        private const double CHANGE_DEFENCE_POINTS = 25.0;
        private const double INITIAL_HEALTH_POINTS = 200.0;


        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name,
                  attackPoints + CHANGE_ATTACK_POINTS,
                  defensePoints - CHANGE_DEFENCE_POINTS,
                  INITIAL_HEALTH_POINTS)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public string AggressiveModeString
        {
            get
            {
                return this.AggressiveMode ? "ON" : "OFF";
            }
        }

        public void ToggleAggressiveMode()
        {
            if (AggressiveMode)
            {
                AggressiveMode = false;
                AttackPoints -= CHANGE_ATTACK_POINTS;
                DefensePoints += CHANGE_DEFENCE_POINTS;

            }
            else
            {
                AggressiveMode = true;
                AttackPoints += CHANGE_ATTACK_POINTS;
                DefensePoints -= CHANGE_DEFENCE_POINTS;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            if (AggressiveMode)
            {
                sb.AppendLine(" *Aggressive: ON");
            }
            else
            {
                sb.AppendLine(" *Aggressive: OFF");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
