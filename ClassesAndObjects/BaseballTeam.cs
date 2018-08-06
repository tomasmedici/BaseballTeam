using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class BaseballTeam
    {
        private string name;
        private string stadium;
        private int wins = 0;
        private int defeats = 0;

        public BaseballTeam(string n, string s, string f)
        {
            this.name = n;
            this.stadium = s;
            this.field = f;
        }
    }
}
