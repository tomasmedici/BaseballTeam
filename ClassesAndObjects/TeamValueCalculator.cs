using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class TeamValueCalculator
    {

        private int teamvalue;
        private int agetotal;

        public TeamValueCalculator()
        {
        }

        public int CalculateValue(BaseballPlayer[] players) // params int[] players)
        {
            teamvalue = 0;
            for (int i = 0; i < players.Length; i++)
            {
                this.teamvalue = this.teamvalue + players[i].value; // this.teamvalue + players[i];
            }
            return teamvalue;
        }

        public float CalculateAverageAge(BaseballPlayer[] players)
        {
            agetotal = 0;
            float length = players.Length;
            for (int i = 0; i < length; i++)
            {
                agetotal = this.agetotal + players[i].age;
                Console.WriteLine(agetotal);
            }
            // Console.WriteLine(agetotal, length);
            return agetotal / length; 
        }
        
    }


}
