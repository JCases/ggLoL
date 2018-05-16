using System;
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

                APIItem patch = new APIItem(region, link);

                // Get First Result
                string numberPatch = patch.json.Split('\"')[1];

                return client.DownloadString("https://euw.leagueoflegends.com" +
                    "/en/news/game-updates/patch/patch-" + numberPatch + "-notes");
            }
            catch (Exception) { return ""; }
        }

        public void SetFreeChampions()
        {
            APIObject connection = new APIObject(region, Champions.GetLink() 
                + "?freeToPlay=true");
            FreeChampions fc =
                JsonConvert.DeserializeObject<FreeChampions>(connection.json);

            // Get all info to Champion and save in List
            freeChampions = new List<Champion>();

            foreach (Champion c in champions.listChamp)
            {
                for (int i = 0; i < fc.lFreeCham.Count; i++)
                    if (fc.lFreeCham[0].id.ToString() == c.keys.Item1)
                        freeChampions.Add(c);
            }
        }

        public string Patch()
        {
            string code = GetPatchCode();

            // Use Linq for Replace
            code = code.Replace(@"<(.|\\n)*?>", "");

            return code;
        }
    }
}
