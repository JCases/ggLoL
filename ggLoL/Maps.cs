using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class Maps
    {
        public Dictionary<string, MapDetailsDto> data { get; set; }
        public string version { get; set; }
        public string type { get; set; }

        public static string GetLink()
        {
            return "lol/static-data/v3/maps";
        }

        private const string fileName = "maps.json";

        public void Save(Maps m)
        {
            string maps = JsonConvert.SerializeObject(m);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(maps);
            writer.Close();
        }

        public Maps Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string maps = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<Maps>(maps);
        }

        // -- STRUCTS -- // 

        public struct MapDetailsDto
        {
            public string mapName { get; set; }
            public ImageDto image { get; set; }
            public long mapId { get; set; }
            public List<long> unpurchasableItemList { get; set; }
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
    }
}
