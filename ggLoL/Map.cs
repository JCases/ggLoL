﻿using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    class Map
    {
        public MapDataDto map { get; set; }

        public static string GetLink()
        {
            return "lol/static-data/v3/maps";
        }

        private const string fileName = "maps.json";

        public void Save(Map c)
        {
            string maps = JsonConvert.SerializeObject(c);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(maps);
            writer.Close();
        }

        public Map Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string maps = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Map>(maps);
        }

        public struct MapDataDto
        {
            public Dictionary<string,MapDetailsDto> data;
            public string version;
            public string type;
        }

        public struct MapDetailsDto
        {
            public string mapName;
            public ImageDto image;
            public long mapId;
            public List<long> unpurchasableItemList;
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
    }
}
