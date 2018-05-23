using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System;

namespace ggLoL
{
    abstract public class ggLoLMain
    {
        protected static string region { get; set; }

        protected static bool online { get; set; }

        public static void setRegion(string txtRegion)
        {
            // SELECT FROM CHECKBOX PREDEFINED VALUES
            Region r = new Region(txtRegion);
            region = r.linkRegion;
        }

        public static bool SearchPlayer(string name, out SummonerProfile s)
        {
            try
            {
                ConnectionAPI connection =
                new ConnectionAPI(name, APILinks.GetLink(
                APILinks.Link.SummonerProfile));

                s = JsonConvert.DeserializeObject<SummonerProfile>(connection.json);

                return true;
            }
            catch { s = null; MessageBox.Show("Player don't found!"); return false;  }
            
        }

        // For Download File Data
        public static string GetLinkFileData()
        {
            ConnectionAPI connection =
                new ConnectionAPI(APILinks.GetLink(APILinks.Link.DragontailData));

            string link = JsonConvert.DeserializeObject<string>(connection.json);

            return link;
        }
    }
}
