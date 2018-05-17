using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class News : ggLoLMain
    {
        public List<Champion> freeChampions { get; set; }

        public string GetPatchCode()
        {
            const string link = "/lol/static-data/v3/versions";

            try
            {
                WebClient client = new WebClient();

                ConnectionAPI patch = new ConnectionAPI(region, link);

                // Get First Result
                string numberPatch = patch.json.Split('\"')[1];

                return client.DownloadString("https://euw.leagueoflegends.com" +
                    "/en/news/game-updates/patch/patch-" + numberPatch + "-notes");
            }
            catch (Exception) { return ""; }
        }

        public void SetFreeChampions()
        {
            // TO DO: NOT WORK - NOT DESERIALIZE OBJECTS
            try
            {
                ConnectionAPI connection = new ConnectionAPI(region, FreeChampions.GetLink());
                FreeChampions fc =
                    JsonConvert.DeserializeObject<FreeChampions>(connection.json);
            }
            catch (Exception) { }
        }

        public string Patch()
        {
            string code = GetPatchCode();

            // Use Linq for Replace
            code = code.Replace("<(.|\\n)*?>", "");

            return code;
        }
    }
}
