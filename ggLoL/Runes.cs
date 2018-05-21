using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Runes
    {
        public List<ReforgedRuneDto> runes { get; set; }

        private const string fileName = "runes.json";

        public void Save(Runes r)
        {
            string runes = JsonConvert.SerializeObject(r);
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
            public string runePathName { get; set; }
            public int runePathId { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string shortDesc { get; set; }
            public string longDesc { get; set; }
            public string icon { get; set; }
        }
    }
}
