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

        public static bool SearchChampion(out Champions c)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(
                    APILinks.Link.Champions));

                c = JsonConvert.DeserializeObject<Champions>(connection.json);

                return true;
            }
            catch { c = null; MessageBox.Show("Champion don't found!"); return false; }
        }

        // For Download File Data
        public static bool GetLinkFileData(out string link)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(APILinks.Link.DragontailData));

                link = JsonConvert.DeserializeObject<string>(connection.json);

                return true;
            }
            catch { link = null; MessageBox.Show("Connection error"); return false; }
            
        }
    }
}
