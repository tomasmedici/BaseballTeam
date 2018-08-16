using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class BaseballPlayer
    {
        public int value;
        public int age;
        public int weight;
        public int id;
        public string firstname;
        public string lastname;

        public BaseballPlayer(int v, int a, int w, int i, string fn, string ln)
        {
            this.value = v;
            this.age = a;
            this.weight = w;
            this.id = i;
            this.firstname = fn;
            this.lastname = ln;
        }

        public void PlayerDynamicAge()
        {
            this.age++;
        }
    }

   
}
