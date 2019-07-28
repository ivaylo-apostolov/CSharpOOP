using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public int Count => this.Players.Count;

        public IReadOnlyCollection<IPlayer> Players => this.players.AsReadOnly();

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException(Message.PlayerCannotBeFound);
            }

            if (players.Any(p => p.Username == player.Username))
            {
                throw new ArgumentException(String.Format(Message.PlayerNameAlreadyExists, player.Username));
            }

            players.Add(player);
        }

        public IPlayer Find(string username)
        {
            IPlayer player = players.FirstOrDefault(p => p.Username == username);

            return player;
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException(Message.PlayerCannotBeFound);
            }

            if (players.Contains(player))
            {
                players.Remove(player);
                return true;
            }

            return false;
        }
    }
}
