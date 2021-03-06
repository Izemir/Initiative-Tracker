﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Initiative_Tracker
{
    class JsonReader
    {

        List<Creature> creatures { get; set; }

        public Boolean error { get; set; }

        public JsonReader() {
            creatures = new List<Creature>();

            error = false;
        }


        public List <Creature> Read(int id, bool isMonster)
        {

            try
            {

                if (isMonster)
                {
                    using (StreamReader r = new StreamReader("creatures.json"))
                    {

                        string json = r.ReadLine();
                        creatures = JsonConvert.DeserializeObject<List<Creature>>(json);


                    }
                }
                else
                {
                    using (StreamReader r = new StreamReader("players.json"))
                    {

                        string json = r.ReadLine();
                        creatures = JsonConvert.DeserializeObject<List<Creature>>(json);


                    }

                }

                


                
            }
            catch (FileNotFoundException ex) { error = true; }




            return creatures;
        }

    }
}
