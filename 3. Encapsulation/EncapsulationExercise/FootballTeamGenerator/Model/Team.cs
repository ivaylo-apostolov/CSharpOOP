using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Model
{
    public class Team
    {
        private string name;

        private int rating;

        private int numberOfPlayers;

        private Player Player;

        public Team(string name)
        {
            this.name = name;
        }


    }
}
