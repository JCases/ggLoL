using System;
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

        public struct InfoDto
        {
            public int difficulty;
            public int attack;
            public int defense;
            public int magic;
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

        public struct SkinDto
        {
            public int num;
            public int name;
            public int id;
        }

        public struct PassiveDto
        {
            public ImageDto image;
            public string sanitizedDescription;
            public string name;
            public string description;
        }

        public struct RecommendedDto
        {
            public string map;
            public List<BlockDto> blocks;
            public string champion;
            public string title;
            public bool priority;
            public string mode;
            public string type;
        }

        public struct BlockDto
        {
            public List<BlockItemDto> item;
            public bool recMath;
            public string type;
        }

        public struct BlockItemDto
        {
            public int count;
            public int id;
        }

        public struct ChampionSpellDto
        {
            public string cooldownBurn;
            public string resource;
            public string leveltip;
            public List<SpellVarsDto> vars;
            public string costType;
            public ImageDto image;
            public string sanitizedDescription;
            public string sanitizedTooltip;
            public List<List<double>> effect;
            public string tooltip;
            public int maxrank;
            public string costBurn;
            public string rangeBurn;
            public object range;
            public List<double> cooldown;
            public List<int> cost;
            public string key;
            public string description;
            public List<string> effectBurn;
            public List<ImageDto> altimages;
            public string name;
        }

        public struct LevelTipDto 
        {

        }

        public struct SpellVarsDto
        {

        }

        // TO DO -> SKINS IN ANOTHER SEASON

        public Tuple<string, string> keys { get; set; }
        public Tuple<string, ChampionDto> data { get; set; }
        public string version { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }
}
