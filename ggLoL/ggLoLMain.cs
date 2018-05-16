using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class ggLoLMain
    {
        protected string region { get; set; }

        protected bool online { get; }

        public ggLoLMain()
        {
            online = true;

            region = "euw1";
        }

        public Champions GetListChampions()
        {
            APIObject connection = new APIObject(region, Champions.GetLink());
            Champions champions = new Champions();
            champions = 
                JsonConvert.DeserializeObject<Champions>(connection.json);
            return champions;
        }

        public void SaveChampion(Champion c)
        {
            string champion = JsonConvert.SerializeObject(c);
            StreamWriter writer = new StreamWriter(c.keys.Item2 + ".json");
        }

        public Champion LoadChampion(string nameFile)
        {
            StreamReader reader = new StreamReader(nameFile);
            string champion = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<Champion>(champion);
        }
    }
}
