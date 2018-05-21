using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Champions
    {
        public List<Champion> listChamp { get; set; }

        public Champions(List<Champion> listChamp)
        {
            this.listChamp = listChamp;
        }

        public static string GetLink()
        {
            return "lol/static-data/v3/champions";
        }

        private const string fileName = "champions.json";

        public void Save(Champions c)
        {
            string champions = JsonConvert.SerializeObject(c);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(champions);
            writer.Close();
        }

        public Champions Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string champion = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Champions>(champion);
        }
    }
}
