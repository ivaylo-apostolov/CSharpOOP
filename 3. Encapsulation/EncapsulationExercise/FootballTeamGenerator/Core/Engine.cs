using System;
using System.Collections.Generic;
using System.Text;

using FootballTeamGenerator.Model;

namespace FootballTeamGenerator.Core
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            try
            {
                Stat stat = new Stat(100, 100, 100, 100, 111);
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine(ar.Message);
            }
        }
    }
}
