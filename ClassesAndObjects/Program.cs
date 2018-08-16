using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseballPlayer p1 = new BaseballPlayer(10000, 25, 90, 1001, "Pete", "Povert");
            BaseballPlayer p2 = new BaseballPlayer(12000, 24, 110, 1002, "Stewie", "Stupid");
            BaseballPlayer p3 = new BaseballPlayer(14000, 24, 87, 1003, "Donnie", "Dummy");
            BaseballPlayer p4 = new BaseballPlayer(8000, 29, 99, 1004, "Brian", "Brighty");
            BaseballPlayer[] SFGplayers = new BaseballPlayer[] { p1, p2, p3, p4 };
            BaseballTeam sf = new BaseballTeam("San Francisco Giants",
                                                "Candlestick Park",
                                                SFGplayers);
            DynamicEngine dE = new DynamicEngine();
            dE.RunYears(sf);
            Console.WriteLine("The year is now: " + dE.WhichYear() + ", and the average age of the players is now: " + dE.WhatAverageAge());




            sf.PlayGame(7, 1);
            sf.PlayGame(500, 5);
            sf.PlayGame(BaseballTeam.Result.Win);
            sf.PlayGame(BaseballTeam.Result.Lose);
            sf.PlayGame(BaseballTeam.Result.Cancelled);

            // Console.WriteLine(sf.ToString());
            // Console.WriteLine("Record: " + sf.Record);
            // sf.Ballpark = "3Com Park";
            // Console.WriteLine(sf.ToString());
                     
            TeamValueCalculator tv = new TeamValueCalculator();

            Console.WriteLine("Teamvalue is: " + tv.CalculateValue( sf.players ));
            Console.WriteLine("Average age is: " + tv.CalculateAverageAge( sf.players ));
            p1.PlayerDynamicAge();
            Console.WriteLine("Average age is now: " + tv.CalculateAverageAge( sf.players ));

            sf = null;

            Console.ReadKey();
        }
    }
}
