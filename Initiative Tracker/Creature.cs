using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiative_Tracker
{
    class Creature
    {
        public String name { get; set; }

        public bool isMonster { get; set; }

        public int bonus { get; set; }

        public Creature(String name, int bonus, bool isMonster)
        {
            this.name = name;
            this.bonus = bonus;
            this.isMonster = isMonster;
        }



    }
}
