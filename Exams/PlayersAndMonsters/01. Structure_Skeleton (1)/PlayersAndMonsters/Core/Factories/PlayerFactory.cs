using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            ICardRepository cardRepository = new CardRepository();
            IPlayer player = null;

            if (type == typeof(Beginner).Name)
            {
                player = new Beginner(cardRepository, username);
            }
            else if (type == typeof(Advanced).Name)
            {
                player = new Advanced(cardRepository, username);
            }

            return player;
        }
    }
}
