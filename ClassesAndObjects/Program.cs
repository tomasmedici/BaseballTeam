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
            BaseballTeam sf = new BaseballTeam("San Francisco Giants",
                                                "Candlestick Park");

            sf.PlayGame(7, 1);
            sf.PlayGame(500, 5);
            sf.PlayGame(BaseballTeam.Result.Win);
            sf.PlayGame(BaseballTeam.Result.Lose);

            Console.Out.WriteLine("Record: " + sf.Record);
            sf.Ballpark = "3Com Park";

            Console.Out.WriteLine(sf.ToString());

            sf = null;

            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
