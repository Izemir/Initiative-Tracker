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

        public int passPerception { get; set; }

        public int bonusPerception { get; set; }

        public int bonusStealth { get; set; }
        public int ac { get; set; }

        public int hits { get; set; }

        public int hitDice { get; set; }

        public int bonusHit { get; set; }



        public Creature(String name, int bonus, bool isMonster)
        {
            this.name = name;
            this.bonus = bonus;
            this.isMonster = isMonster;
        }



    }
}
