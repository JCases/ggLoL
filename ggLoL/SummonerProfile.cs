using System.IO;
using Newtonsoft.Json;

namespace ggLoL
{
    public class SummonerProfile
    {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public long summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountId { get; set; }

        private string fileName = "-account.json";

        public void Save(SummonerProfile s)
        {
            fileName = name + fileName;
            string accounts = JsonConvert.SerializeObject(s);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(accounts);
            writer.Close();
        }

        public SummonerProfile Load(string name)
        {
            StreamReader reader = new StreamReader(name + fileName);
            string accounts = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<SummonerProfile>(accounts);
        }
    }
}
