using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Common
{
    public static class Message
    {
        public static string PlayerNameCannotBeNullOrEmptyString = "Player's username cannot be null or an empty string. ";

        public static string PlayerHealthCannotBeLessThanZero = "Player's health bonus cannot be less than zero. ";

        public static string DamagePointsCannotBeLessThanZero = "Damage points cannot be less than zero.";

        public static string CardNameCannotBeNullOrEmptyString = "Card's name cannot be null or an empty string.";

        public static string CardDamagePointsCannotBeLessThanZero = "Card's damage points cannot be less than zero.";

        public static string CardHPCannotBeLessThanZero = "Card's HP cannot be less than zero.";

        public static string PlayerIsDead = "Player is dead!";

        public static string CardCannotBeNull = "Card cannot be null!";

        public static string CardNameAlreadyExists = "Card {0} already exists!";

        public static string PlayerCannotBeFound = "Player cannot be null";

        public static string PlayerNameAlreadyExists = "Player {0} already exists!";
    }
}
