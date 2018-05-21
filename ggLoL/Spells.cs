using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Spells
    {
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, SummonerSpellDto> data { get; set; }

        private const string fileName = "spells.json";

        public void Save(Spells s)
        {
            string spells = JsonConvert.SerializeObject(s);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(spells);
            writer.Close();
        }

        public Spells Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string spells = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Spells>(spells);
        }

        // -- STRUCTS -- // 

        public struct SummonerSpellDto
        {
            public List<SpellVarsDto> vars { get; set; }
            public ImageDto image { get; set; }
            public string costBurn { get; set; }
            public List<double> cooldown { get; set; }
            public List<string> effectBurn { get; set; }
            public int id { get; set; }
            public string cooldownBurn { get; set; }
            public string tooltip { get; set; }
            public int maxrank { get; set; }
            public string rangeBurn { get; set; }
            public string description { get; set; }
            public List<List<double>> effect { get; set; }
            public string key { get; set; }
            public LevelTipDto leveltip { get; set; }
            public List<string> modes { get; set; }
            public string resource { get; set; }
            public string name { get; set; }
            public string costType { get; set; }
            public string sanitizedDescription { get; set; }
            public string sanitizedTooltip { get; set; }
            public List<string> range { get; set; }
            public List<int> cost { get; set; }
            public int summonerLevel { get; set; }
        }

        public struct SpellVarsDto
        {
            public string ranksWith { get; set; }
            public string dyn { get; set; }
            public string link { get; set; }
            public List<double> coeff { get; set; }
            public string key { get; set; }
        }

        public struct ImageDto
        {
            public string full { get; set; }
            public string group { get; set; }
            public string sprite { get; set; }
            public int h { get; set; }
            public int w { get; set; }
            public int y { get; set; }
            public int x { get; set; }
        }

        public struct LevelTipDto
        {
            public List<string> effect { get; set; }
            public List<string> label { get; set; }
        }
    }
}
