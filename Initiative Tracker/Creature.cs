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
        
        public short bonus { get; set; }

        public Creature(String name, short bonus)
        {
            this.name = name;
            this.bonus = bonus;
        }



    }
}
