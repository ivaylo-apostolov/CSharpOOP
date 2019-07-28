using PlayersAndMonsters.Common;
using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException(Message.PlayerIsDead);
            }

            CheckIfThePlayerIsBeginner(attackPlayer);
            CheckIfThePlayerIsBeginner(enemyPlayer);

            GetBonusHealth(attackPlayer);
            GetBonusHealth(enemyPlayer);

            while (true)
            {
                int attackPlayerDamageSum = attackPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);
                int enemyPlayerDamageSum = enemyPlayer.CardRepository.Cards.Sum(c => c.DamagePoints);

                enemyPlayer.TakeDamage(attackPlayerDamageSum);
                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayerDamageSum);
                if (attackPlayer.IsDead)
                {
                    break;
                }


            }

        }

        private void GetBonusHealth(IPlayer attackPlayer)
        {
            foreach (var card in attackPlayer.CardRepository.Cards)
            {
                attackPlayer.Health += card.HealthPoints;
            }
        }

        private static void CheckIfThePlayerIsBeginner(IPlayer attackPlayer)
        {
            if (attackPlayer.GetType().Name == "Beginner")
            {
                attackPlayer.Health += 40;

                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
        }
    }
}
