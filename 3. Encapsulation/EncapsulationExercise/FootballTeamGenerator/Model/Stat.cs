using FootballTeamGenerator.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Model
{
    public class Stat
    {
        private int endurance;

        private int sprint;

        private int dribble;

        private int passing;

        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                ValidateStat(value, nameof(this.Endurance));                

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                ValidateStat(value, nameof(this.Sprint));

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                ValidateStat(value, nameof(this.Dribble));

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }
            private set
            {
                ValidateStat(value, nameof(this.Passing));

                this.passing = value;

            }
        }

        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                ValidateStat(value, nameof(this.Shooting));

                this.shooting = value;
            }
        }

        private void ValidateStat(int number, string name)
        {
            if (number < 0 || number > 100)
            {
                throw new ArgumentException(String.Format(ExeptionMessage.StatsShouldBeBetween0and100, name));
            }
        }

        public double OverallStat()
        {
            return ((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);

        }
    }
}
