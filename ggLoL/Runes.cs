using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Runes
    {
        public List<ReforgedRuneDto> runes { get; set; }

        public static string GetLink()
        {
            return "lol/static-data/v3/reforged-runes";
        }

        private const string fileName = "runes.json";

        public void Save(Runes c)
        {
            string runes = JsonConvert.SerializeObject(c);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(runes);
            writer.Close();
        }

        public Runes Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string runes = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Runes>(runes);
        }

        public struct ReforgedRuneDto
        {
            public string runePathName;
            public int runePathId;
            public string name;
            public int id;
            public string key;
            public string shortDesc;
            public string longDesc;
            public string icon;
        }
    }
}
