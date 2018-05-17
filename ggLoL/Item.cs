using System;
using System.Collections.Generic;

namespace ggLoL
{
    class Item
    {
        struct ItemListDto
        {
            Dictionary<string, ItemDto> data;
            string version;
            List<ItemTreeDto> tree;
            List<GroupDto> groups;
            string type;
        }

        struct ItemTreeDto
        {
            string header;
            List<string> tags;
        }

        struct ItemDto
        {
            GoldDto gold;
            string plaintext;
            bool hideFromAll;
            bool inStore;
            List<string> into;
            int id;
            InventoryDataStatsDto stats;
            string colloq;
            Dictionary<string, bool> maps;
            int specialRecipe;
            ImageDto image;
            string description;
            List<string> tags;
            Dictionary<string, string> effect;
            string requiredChampion;
            List<string> from;
            string group;
            bool consumeOnFull;
            string name;
            bool consumed;
            string sanitizedDescription;
            int depth;
            int stacks;
        }
        struct GoldDto
        {
            int sell;
            int total;
            int bases;
            bool purchasable;
        }

        struct InventoryDataStatsDto
        {
            double PercentCritDamageMod;
            double PercentSpellBlockMod;
            double PercentHPRegenMod;
            double PercentMovementSpeedMod;
            double FlatSpellBlockMod;
            double FlatCritDamageMod;
            double FlatEnergyPoolMod;
            double PercentLifeStealMod;
            double FlatMPPoolMod;
            double FlatMovementSpeedMod;
            double PercentAttackSpeedMod;
            double FlatBlockMod;
            double PercentBlockMod;
            double FlatEnergyRegenMod;
            double PercentSpellVampMod;
            double FlatMPRegenMod;
            double PercentDodgeMod;
            double FlatAttackSpeedMod;
            double FlatArmorMod;
            double FlatHPRegenMod;
            double PercentMagicDamageMod;
            double PercentMPPoolMod;
            double FlatMagicDamageMod;
            double PercentMPRegenMod;
            double PercentPhysicalDamageMod;
            double FlatPhysicalDamageMod;
            double PercentHPPoolMod;
            double PercentArmorMod;
            double PercentCritChanceMod;
            double PercentEXPBonus;
            double FlatHPPoolMod;
            double FlatCritChanceMod;
            double FlatEXPBonus;
        }

        struct ImageDto
        {
            string full;
            string group;
            string sprite;
            int h;
            int w;
            int y;
            int x;
        }

        struct GroupDto
        {
            string MaxGroupOwnable;
            string key;
        }
    }
}   
