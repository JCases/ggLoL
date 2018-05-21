using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        // Only 1 Search for Static Data -> CREATE CLASS STATIC DATA WHERE SAVE 
        // ALL DATA
        public static void GetListChampions()
        {
            ConnectionAPI connection =
                new ConnectionAPI(LinksAPI.GetLinksAPI(LinksAPI.Link.FreeChampions));
            FreeChampions champions = new FreeChampions();
            champions = JsonConvert.DeserializeObject<FreeChampions>(connection.json);

            MessageBox.Show(champions.champions[0].id.ToString());
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
