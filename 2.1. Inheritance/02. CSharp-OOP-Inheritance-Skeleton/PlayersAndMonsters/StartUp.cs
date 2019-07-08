namespace PlayersAndMonsters
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DarkWizard darkWizard = new DarkWizard("Dark", 30);

            SoulMaster soul = new SoulMaster("Soul", 20);
            Console.WriteLine(soul);
            Console.WriteLine(darkWizard);
        }
    }
}