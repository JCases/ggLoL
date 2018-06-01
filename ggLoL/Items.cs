using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Items
    {
        public Dictionary<string, ItemDto> data { get; set; }
        public string version { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public List<GroupDto> groups { get; set; }
        public string type { get; set; }

        public static string fileName = "items.json";

        public void Save()
        {
            string items = JsonConvert.SerializeObject(this);
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
            public string header { get; set; }
            public List<string> tags { get; set; }
        }

        public struct ItemDto
        {
            public GoldDto gold { get; set; }
            public string plaintext { get; set; }
            public bool hideFromAll { get; set; }
            public bool inStore { get; set; }
            public List<string> into { get; set; }
            public int id { get; set; }
            public InventoryDataStatsDto stats { get; set; }
            public string colloq { get; set; }
            public Dictionary<string, bool> maps { get; set; }
            public int specialRecipe { get; set; }
            public ImageDto image { get; set; }
            public string description { get; set; }
            public List<string> tags { get; set; }
            public Dictionary<string, string> effect { get; set; }
            public string requiredChampion { get; set; }
            public List<string> from { get; set; }
            public string group { get; set; }
            public bool consumeOnFull { get; set; }
            public string name { get; set; }
            public bool consumed { get; set; }
            public string sanitizedDescription { get; set; }
            public int depth { get; set; }
            public int stacks { get; set; }
        }

        public struct GoldDto
        {
            public int sell { get; set; }
            public int total { get; set; }
            public int @base { get; set; }
            public bool purchasable { get; set; }
        }

        public struct InventoryDataStatsDto
        {
            public double PercentCritDamageMod { get; set; }
            public double PercentSpellBlockMod { get; set; }
            public double PercentHPRegenMod { get; set; }
            public double PercentMovementSpeedMod { get; set; }
            public double FlatSpellBlockMod { get; set; }
            public double FlatCritDamageMod { get; set; }
            public double FlatEnergyPoolMod { get; set; }
            public double PercentLifeStealMod { get; set; }
            public double FlatMPPoolMod { get; set; }
            public double FlatMovementSpeedMod { get; set; }
            public double PercentAttackSpeedMod { get; set; }
            public double FlatBlockMod { get; set; }
            public double PercentBlockMod { get; set; }
            public double FlatEnergyRegenMod { get; set; }
            public double PercentSpellVampMod { get; set; }
            public double FlatMPRegenMod { get; set; }
            public double PercentDodgeMod { get; set; }
            public double FlatAttackSpeedMod { get; set; }
            public double FlatArmorMod { get; set; }
            public double FlatHPRegenMod { get; set; }
            public double PercentMagicDamageMod { get; set; }
            public double PercentMPPoolMod { get; set; }
            public double FlatMagicDamageMod { get; set; }
            public double PercentMPRegenMod { get; set; }
            public double PercentPhysicalDamageMod { get; set; }
            public double FlatPhysicalDamageMod { get; set; }
            public double PercentHPPoolMod { get; set; }
            public double PercentArmorMod { get; set; }
            public double PercentCritChanceMod { get; set; }
            public double PercentEXPBonus { get; set; }
            public double FlatHPPoolMod { get; set; }
            public double FlatCritChanceMod { get; set; }
            public double FlatEXPBonus { get; set; }
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

        public struct GroupDto
        {
            public string MaxGroupOwnable { get; set; }
            public string key { get; set; }
        }
    }
}   
