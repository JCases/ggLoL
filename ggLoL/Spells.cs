using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Spells
    {
        public struct SummonerSpellListDto
        {
            public Tuple<string, SummonerSpellDto> data;
            public string version;
            public string type;
        }

        public struct SummonerSpellDto
        {
            public List<SpellVarsDto> vars;
            public ImageDto image;
            public string costcostBurn;
            public List<double> cooldown;
            public List<string> effectBurn;
            public int id;
            public string cooldownBurn;
            public string tooltip;
            public int maxrank;
            public string rangeBurn;
            public string description;
            public List<List<double>> effect;
            public string key;
            public LevelTipDto leveltip;
            public List<string> modes;
            public string resource;
            public string name;
            public string costType;
            public string sanitizedDescription;
            public string sanitizedTooltip;
            public List<string> range;
            public List<int> cost;
            public int summonerLevel;
        }

        public struct SpellVarsDto
        {
            public string ranksWith;
            public string dyn;
            public string link;
            public List<double> coeff;
            public string key;
        }

        public struct ImageDto
        {
            public string full;
            public string group;
            public string sprite;
            public int h;
            public int w;
            public int y;
            public int x;
        }

        public struct LevelTipDto
        {
            public List<string> effect;
            public List<string> label;
        }

        public List<SummonerSpellListDto> spells;

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
    }
}
