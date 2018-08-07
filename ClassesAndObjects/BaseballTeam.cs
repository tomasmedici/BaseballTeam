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
        private int draws = 0;



        public BaseballTeam(string n, string s)
        {
            this.name = n;
            this.stadium = s;
        }

        public void PlayGame(int runsFor, int runsAgainst)
        {
            if (runsFor > runsAgainst)
            {
                this.wins++;
            }
            else if (runsAgainst > runsFor)
            {
                this.defeats++;
            }
            else
            {
                this.draws++;
            }
        }

        public override string ToString()
        {
            return this.name + ", play at " + this.stadium + ": " + " W:" + this.wins + " L:" + this.defeats + " D:" + this.draws;
        }

        public enum Result { Win, Lose, Draw }

        public void PlayGame(Result r)
        {
            if (r == Result.Win)
                this.wins++;
            else if (r == Result.Lose)
                this.defeats++;
            else
                this.draws++;
        }

        public double Record
        {
            get
            {
                int played = this.wins + this.defeats;
                return (double)this.wins / played;
            }
        }

        public string Ballpark
        {
            get
            {
                return this.stadium;
            }
            set
            {
                this.stadium = value; // value is an implicit parameter
            }
        }


    }
}
