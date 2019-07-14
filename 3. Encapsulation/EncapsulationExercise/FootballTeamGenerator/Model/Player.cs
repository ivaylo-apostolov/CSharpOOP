using System;
using System.Collections.Generic;
using System.Text;

using FootballTeamGenerator.Exeptions;

namespace FootballTeamGenerator.Model
{
    public class Player
    {
        private string name;

        public Player(string name, Stat stat)
        {
            this.Name = name;
            this.Stat = stat;
        }

        public string Name
        { 
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessage.ANameShouldNotBeEmpty);
                }

                name = value;
            }
        }

        public Stat Stat { get; private set; }

        public double OverallStat =>
            this.Stat.OverallStat();
    }
}
