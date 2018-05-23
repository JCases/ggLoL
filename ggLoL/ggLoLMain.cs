using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

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

        // DOWNLOAD FILE WITH ALL DATA (TEXTS AND IMAGES)

        public static void DownloadFile()
        {
            WebClient web = new WebClient();

            web.DownloadFile(GetLinkFileData(), "dragontail");

        }

        public static string GetLinkFileData()
        {
            const string link = "";

            ConnectionAPI connection =
                new ConnectionAPI(region, link);

            return connection.json;
        }
    }
}
