using System;

using FootballTeamGenerator.Core;
using FootballTeamGenerator.Model;
using FootballTeamGenerator.Exeptions;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}
