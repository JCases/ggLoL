using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class News : ggLoLMain
    {
        public string GetPatchCode()
        {
            const string link = "/lol/static-data/v3/versions";

            try
            {
                WebClient client = new WebClient();

                ConnectionAPI patch = new ConnectionAPI(link);

                // Get First Result
                string numberPatch = patch.json.Split('\"')[1];

                return client.DownloadString("https://euw.leagueoflegends.com" +
                    "/en/news/game-updates/patch/patch-" + numberPatch + "-notes");
            }
            catch (Exception) { return ""; }
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
