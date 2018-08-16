using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class DynamicEngine
    {
        private int rand1;
        private double rand2;

        public DynamicEngine()
        {
        }
                
        public void RunYears(BaseballTeam team)
        {
            rand1 = 1988;
            rand2 = 51.2;
        }

        public int WhichYear()
        {
            return rand1;
        }

        public double WhatAverageAge()
        {
            return rand2;
        }
    }
}
