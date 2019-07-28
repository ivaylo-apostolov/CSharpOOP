using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO;
using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private readonly IManagerController managerController;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.managerController = new ManagerController();
        }

        public void Run()
        {
            string input = string.Empty;
            var sb = new StringBuilder();

            while ((input = reader.ReadLine()) != "Exit")
            {
                var tokens = input
                    .Split()
                    .ToArray();

                string command = tokens[0];

                try
                {
                    if (command == "AddPlayer")
                    {
                        string playerType = tokens[1];
                        string playerName = tokens[2];

                        sb.AppendLine(managerController.AddPlayer(playerType, playerName));
                    }
                    else if (command == "AddCard")
                    {
                        string cardType = tokens[1];
                        string cardName = tokens[2];

                        sb.AppendLine(managerController.AddCard(cardType, cardName));
                    }
                    else if (command == "AddPlayerCard")
                    {
                        string userName = tokens[1];
                        string cardName = tokens[2];

                        sb.AppendLine(managerController.AddPlayerCard(userName, cardName));
                    }
                    else if (command == "Fight")
                    {
                        string attackUser = tokens[1];
                        string enemyUser = tokens[2];

                        sb.AppendLine(managerController.Fight(attackUser, enemyUser));
                    }
                    else if (command == "Report")
                    {
                        sb.AppendLine(managerController.Report());
                    }
                }
                catch (ArgumentException ae)
                {
                    sb.AppendLine(ae.Message);
                }
                
            }

            writer.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
