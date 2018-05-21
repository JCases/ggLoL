using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Champions
    {
        public Dictionary<string, string> keys { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, ChampionDto> data { get; set; }
        public string format { get; set; }


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

        // -- STRUCTS -- // 

        public struct ChampionDto
        {
            public InfoDto info { get; set; }
            public List<string> enemytips { get; set; }
            public StatsDto stats { get; set; }
            public string name { get; set; }
            public string title { get; set; }
            public List<string> tags { get; set; }
            public string partype { get; set; }
            public PassiveDto passive { get; set; }
            public List<RecommendedDto> recommended { get; set; }
            public List<string> allytips { get; set; }
            public string key { get; set; }
            public string lore { get; set; }
            public int id { get; set; }
            public string blurb { get; set; }
            public List<ChampionSpellDto> spells { get; set; }
        }

        public struct InfoDto
        {
            public int difficulty { get; set; }
            public int attack { get; set; }
            public int defense { get; set; }
            public int magic { get; set; }
        }

        public struct StatsDto
        {
            public double armorperlevel { get; set; }
            public double hpperlevel { get; set; }
            public double attackdamage { get; set; }
            public double mpperlevel { get; set; }
            public double attackspeedoffset { get; set; }
            public double armor { get; set; }
            public double hp { get; set; }
            public double hpregenperlevel { get; set; }
            public double spellblock { get; set; }
            public double attackrange { get; set; }
            public double movespeed { get; set; }
            public double attackdamageperlevel { get; set; }
            public double mpregenperlevel { get; set; }
            public double mp { get; set; }
            public double spellblockperlevel { get; set; }
            public double crit { get; set; }
            public double mpregen { get; set; }
            public double attackspeedperlevel { get; set; }
            public double hpregen { get; set; }
            public double critperlevel { get; set; }
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

        public struct SkinDto
        {
            public int num { get; set; }
            public int name { get; set; }
            public int id { get; set; }
        }

        public struct PassiveDto
        {
            public ImageDto image { get; set; }
            public string sanitizedDescription { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public struct RecommendedDto
        {
            public string map { get; set; }
            public List<BlockDto> blocks { get; set; }
            public string champion { get; set; }
            public string title { get; set; }
            public bool priority { get; set; }
            public string mode { get; set; }
            public string type { get; set; }
        }

        public struct BlockDto
        {
            public List<BlockItemDto> item { get; set; }
            public bool recMath { get; set; }
            public string type { get; set; }
        }

        public struct BlockItemDto
        {
            public int count { get; set; }
            public int id { get; set; }
        }

        public struct ChampionSpellDto
        {
            public string cooldownBurn { get; set; }
            public string resource { get; set; }
            public string leveltip { get; set; }
            public List<SpellVarsDto> vars { get; set; }
            public string costType { get; set; }
            public ImageDto image { get; set; }
            public string sanitizedDescription { get; set; }
            public string sanitizedTooltip { get; set; }
            public List<List<double>> effect { get; set; }
            public string tooltip { get; set; }
            public int maxrank { get; set; }
            public string costBurn { get; set; }
            public string rangeBurn { get; set; }
            public object range { get; set; }
            public List<double> cooldown { get; set; }
            public List<int> cost { get; set; }
            public string key { get; set; }
            public string description { get; set; }
            public List<string> effectBurn { get; set; }
            public List<ImageDto> altimages { get; set; }
            public string name { get; set; }
        }

        public struct LevelTipDto
        {

        }

        public struct SpellVarsDto
        {

        }

        // TO DO -> SKINS IN ANOTHER SEASON
    }
}
