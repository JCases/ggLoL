using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class News : ggLoLMain
    {
        public string code { get; set; }
        public List<string> patch { get; set; }

        public List<Champions> freeChampions { get; set; }

        public void GetPatch()
        {
            const string link = "/lol/static-data/v3/versions";

            WebClient client = new WebClient();

            APIItem patch = new APIItem(region, link);
            
            // Get First Result
            string numberPatch = patch.json.Split('\"')[1];

            code = client.DownloadString("https://euw.leagueoflegends.com" +
                "/en/news/game-updates/patch/patch-" + numberPatch + "-notes");
        }

        public Champions SetFreeChampions()
        {
            const string link = "/lol/summoner/v3/champions?freeToPlay=true";

            APIObject connection = new APIObject(region, link);
            FreeChampions fc =
                JsonConvert.DeserializeObject<FreeChampions>(connection.json);

            Champions freeChampions = new Champions();

            foreach (Champion c in champions.champions)
            {
                foreach (FreeChampion fcs in fc.lFreeCham)
                {
                    // TO DO
                    /*if (fcs.id == c.data[])
                     * {
                     * 
                     * freeChampions.champions.Add(champions.champions[0].);
                     * }
                     */
                }
            }
            return freeChampions;
        }

        public string Patch()
        {
            // Remove Code
            code = code.Remove(0, code.IndexOf("patch-top"));

            // Use Linq for Replace
            code = code.Replace(@"<(.|\\n)*?>", "");

            return code;
        }
    }
}
