using System;

namespace lifeModel_dotnet
{
    class Program
    {
        public class SportsTeam {
            public string Sport { get; set; }
            public string Colors { get; set; }
            public int Championships { get; set; } = 0;
            public string Name { get; set; }

            public override string ToString()
            {
                return $"My favorite {Sport} team is {Name} and their colors are {Colors} and they have won {Championships} championships.";
            }

            // public SportsTeam(string sport, string colors, string name )
            // {
            //     Console.WriteLine("Adding New Team");
            //     Sport = sport;
            //     Colors = colors;
            //     Name = name; 
            // }
        }
        static void Main(string[] args)
        {
            var team = new SportsTeam();

            team.Name = "St. Louis Cardinals";
            team.Sport = "Baseball";
            team.Colors = "Red and White";
            team.Championships = 11;
            Console.WriteLine(team);

            team = new SportsTeam();
            team.Name = "Green Bay Packers";
            team.Sport = "FootBall";
            team.Colors = "Green and Gold";
            team.Championships = 4;
            Console.WriteLine(team);
        }
    }
}
