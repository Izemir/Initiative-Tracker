using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiative_Tracker
{
    class JsonWriter
    {
        List<Creature> creatures = new List<Creature>();

        public JsonWriter()
        {

        }

        public void Write(Creature cr)
        {
            

           

            

            using (StreamWriter file = File.CreateText(@"creatures.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, creatures);
            }



        }
    }
}
