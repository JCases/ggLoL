using System.Collections.Generic;

namespace ggLoL
{
    public class Champion
    {
        public struct ChampionDto
        {
            public InfoDto info;
            public List<string> enemytips;
            public StatsDto stats;
            public string name;
            public string title;
            public List<string> tags;
            public string partype;
            public PassiveDto passive;
            public List<RecommendedDto> recommended;
            public List<string> allytips;
            public string key;
            public string lore;
            public int id;
            public string blurb;
            public List<ChampionSpellDto> spells;
        }

        public struct StatsDto
        {
            public double armorperlevel;
            public double hpperlevel;
            public double attackdamage;
            public double mpperlevel;
            public double attackspeedoffset;
            public double armor;
            public double hp;
            public double hpregenperlevel;
            public double spellblock;
            public double attackrange;
            public double movespeed;
            public double attackdamageperlevel;
            public double mpregenperlevel;
            public double mp;
            public double spellblockperlevel;
            public double crit;
            public double mpregen;
            public double attackspeedperlevel;
            public double hpregen;
            public double critperlevel;
        }

        public struct InfoDto
        {
            public int difficulty;
            public int attack;
            public int defense;
            public int magic;
        }

        public struct PassiveDto
        {
            public string sanitizedDescription;
            public string name;
            public string description;
        }

        // TO DO -> RECOMMEND ITEMS IN ANOTHER SEASON

        public struct RecommendedDto
        {

        }

        public struct BlockItemDto
        {

        }

        public struct ChampionSpellDto
        {

        }

        public struct LevelTipDto
        {

        }

        public struct SpellVarsDto
        {

        }

        // TO DO -> SKINS IN ANOTHER SEASON

        public bool rankedPlayEnabled;
        public bool botEnabled;
        public bool botMmEnabled;
        public bool active;
        public bool freeToPlay;
        public long id;

        public Champion(string region)
        {
            // TO DO
            APIObject connection = new APIObject(region, link);
            connection.GetData();
        }

        const string link = "/lol/summoner/v3/champions";

        // Return Free Rotate Champions from News
        public List<Champion> GetFreeChampions()
        {
            List<Champion> free = new List<Champion>();
            return free;
        }
    }
}
