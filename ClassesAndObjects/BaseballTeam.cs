using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{

    class BaseballTeam
    {
        public string name;
        private string stadium;
        //public BaseballPlayer playerOne;
        //public BaseballPlayer playerTwo;
        //public BaseballPlayer playerThree;
        //public BaseballPlayer playerFour;
        public BaseballPlayer[] players;
        private int wins = 0;
        private int defeats = 0;
        private int draws = 0;
        private int cancelled_due_to_seagulls = 0;
                
        public BaseballTeam(string n, string s, BaseballPlayer[] pls) // BaseballPlayer p1, BaseballPlayer p2, BaseballPlayer p3, BaseballPlayer p4)
        {
            this.name = n;
            this.stadium = s;
            //this.playerOne = p1;
            //this.playerTwo = p2;
            //this.playerThree = p3;
            //this.playerFour = p4;
            this.players = pls; //  new BaseballPlayer[] { this.playerOne, this.playerTwo, this.playerThree, this.playerFour };
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
            else if (runsAgainst == 99)
            {
                this.cancelled_due_to_seagulls++;
            }
            else
            {
                this.draws++;
            }
        }

        public override string ToString()
        {
            return this.name + ", play at " + this.stadium + ": " + " W:" + this.wins + " L:" + this.defeats + " D:" + this.draws + " C:" + this.cancelled_due_to_seagulls;
        }

        public enum Result { Win, Lose, Draw, Cancelled }

        public void PlayGame(Result r)
        {
            if (r == Result.Win)
                this.wins++;
            else if (r == Result.Lose)
                this.defeats++;
            else if (r == Result.Cancelled)
                this.cancelled_due_to_seagulls++;
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
