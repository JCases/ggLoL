﻿using System.IO;
using Newtonsoft.Json;

namespace ggLoL
{
    public class ChampionMastery
    {
        public bool chestGranted { get; set; }
        public int championLevel { get; set; }
        public int championPoints { get; set; }
        public long championId { get; set; }
        public long playerId { get; set; }
        public long championPointsUntilNextLevel { get; set; }
        public int tokensEarned { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public long lastPlayTime { get; set; }

        public static string fileName = "championMastery.json";

        public void Save()
        {
            fileName = playerId + "-" + championId + "-" + fileName;
            string championMastery = JsonConvert.SerializeObject(this);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(championMastery);
            writer.Close();
        }

        public ChampionMastery Load(string playerId, string championId)
        {
            StreamReader reader = new StreamReader(playerId + "-" + championId
                + "-" + fileName);
            string championMastery = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<ChampionMastery>(championMastery);
        }
    }
}
