using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private List<ICard> cards;

        public CardRepository()
        {
            this.cards = new List<ICard>();
        }

        public int Count => this.Cards.Count;

        public IReadOnlyCollection<ICard> Cards => this.cards.AsReadOnly();

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException(Message.CardCannotBeNull);
            }

            if (cards.Any(c => c.Name == card.Name))
            {
                throw new ArgumentException(string.Format(Message.CardNameAlreadyExists, card.Name));
            }
            else
            {
                cards.Add(card);
            }
        }

        public ICard Find(string name)
        {
            ICard card = cards.FirstOrDefault(c => c.Name == name);

            if (card == null)
            {
                throw new ArgumentException(Message.CardCannotBeNull);
            }

            return card;
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException(Message.CardCannotBeNull);
            }

            if (cards.Contains(card))
            {
                cards.Remove(card);
                return true;
            }

            return false;
        }
    }
}
