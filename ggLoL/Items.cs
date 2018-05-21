using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Items // TO DO: FOR FIX
    {
        public Dictionary<string, ItemDto> data { get; set; }
        public string version { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public List<GroupDto> groups { get; set; }
        public string type { get; set; }

        public static string GetLink()
        {
            return "lol/static-data/v3/items";
        }

        private const string fileName = "items.json";

        public void Save(Items i)
        {
            string items = JsonConvert.SerializeObject(i);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(items);
            writer.Close();
        }

        public Items Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string items = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Items>(items);
        }

        // -- STRUCTS -- // 

        public struct ItemTreeDto
        {
            public string header;
            public List<string> tags;
        }

        public struct ItemDto
        {
            public GoldDto gold;
            public string plaintext;
            public bool hideFromAll;
            public bool inStore;
            public List<string> into;
            public int id;
            public InventoryDataStatsDto stats;
            public string colloq;
            public Dictionary<string, bool> maps;
            public int specialRecipe;
            public ImageDto image;
            public string description;
            public List<string> tags;
            public Dictionary<string, string> effect;
            public string requiredChampion;
            public List<string> from;
            public string group;
            public bool consumeOnFull;
            public string name;
            public bool consumed;
            public string sanitizedDescription;
            public int depth;
            public int stacks;
        }

        public struct GoldDto
        {
            public int sell;
            public int total;
            public int bases;
            public bool purchasable;
        }

        public struct InventoryDataStatsDto
        {
            public double PercentCritDamageMod;
            public double PercentSpellBlockMod;
            public double PercentHPRegenMod;
            public double PercentMovementSpeedMod;
            public double FlatSpellBlockMod;
            public double FlatCritDamageMod;
            public double FlatEnergyPoolMod;
            public double PercentLifeStealMod;
            public double FlatMPPoolMod;
            public double FlatMovementSpeedMod;
            public double PercentAttackSpeedMod;
            public double FlatBlockMod;
            public double PercentBlockMod;
            public double FlatEnergyRegenMod;
            public double PercentSpellVampMod;
            public double FlatMPRegenMod;
            public double PercentDodgeMod;
            public double FlatAttackSpeedMod;
            public double FlatArmorMod;
            public double FlatHPRegenMod;
            public double PercentMagicDamageMod;
            public double PercentMPPoolMod;
            public double FlatMagicDamageMod;
            public double PercentMPRegenMod;
            public double PercentPhysicalDamageMod;
            public double FlatPhysicalDamageMod;
            public double PercentHPPoolMod;
            public double PercentArmorMod;
            public double PercentCritChanceMod;
            public double PercentEXPBonus;
            public double FlatHPPoolMod;
            public double FlatCritChanceMod;
            public double FlatEXPBonus;
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

        public struct GroupDto
        {
            public string MaxGroupOwnable;
            public string key;
        }
    }
}   
