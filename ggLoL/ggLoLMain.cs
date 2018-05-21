using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        public static Spells GetListChampions()
        {
            ConnectionAPI connection =
                new ConnectionAPI("locale=en_US&spellListData=all&dataById=true&tags=all", Spells.GetLink());
            Spells champions = 
                JsonConvert.DeserializeObject<Spells>(connection.json);
            return champions;
        }

        // DOWNLOAD FILE WITH ALL DATA (TEXTS AND IMAGES)
        
        public static void DownloadData()
        {
            WebClient web = new WebClient();

            web.DownloadFile(GetLinkFileData(), "dragontail");

        }

        public static string GetLinkFileData()
        {
            const string link = "lol/static-data/v3/tarball-links";

            ConnectionAPI connection =
                new ConnectionAPI(region, link);

            return connection.json;
        }
    }
}
