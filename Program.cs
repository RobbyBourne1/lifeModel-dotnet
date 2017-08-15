using System;

namespace lifeModel_dotnet
{
    class Program
    {
        public class SportsTeam 
        {
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

        public class Vehicle
        {
            public string Make { get; set; }
            public string YearMade { get; set; }
            public bool IsSUV { get; set; } = false;
            public DateTime DayLogged { get; set; } = DateTime.Now;
            public string OwnerName { get; set; }

            public Vehicle (string make, string yearMade)
            {
                Make = make;
                YearMade = yearMade;
            }

            public Boolean SUV(string owner)
            {
                IsSUV = true;
                OwnerName = owner;
                return IsSUV;
            }

            public override string ToString()
            {
                return $"{OwnerName} has bought a {YearMade}, {Make} and is not an SUV {IsSUV} on {DayLogged}";
            }
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

            var car = new Vehicle("VolksWagen", "2012");
            car.SUV("Robby Bourne");

            Console.WriteLine(car);

        }
    }
}
