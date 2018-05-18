using System.Net;
using Newtonsoft.Json;

namespace ggLoL
{
    public class ggLoLMain
    {
        protected string region { get; set; }

        protected bool online { get; }

        public ggLoLMain()
        {
            // SELECT FROM CHECKBOX PREDEFINED VALUES
            Region region = new Region("EUW");
            this.region = region.linkRegion;

            online = true;
        }

        // Only 1 Search for Static Data -> CREATE CLASS STATIC DATA WHERE SAVE 
        // ALL DATA
        public Champions GetListChampions()
        {
            ConnectionAPI connection =
                new ConnectionAPI(region, Champions.GetLink());
            Champions champions = new Champions();
            champions = 
                JsonConvert.DeserializeObject<Champions>(connection.json);
            return champions;
        }

        // DOWNLOAD FILE WITH ALL DATA (TEXTS AND IMAGES)
        
        public void DownloadData()
        {
            WebClient web = new WebClient();

            web.DownloadFile(GetLinkFileData(), "dragontail");

        }

        public string GetLinkFileData()
        {
            const string link = "lol/static-data/v3/tarball-links";

            ConnectionAPI connection =
                new ConnectionAPI(region, link);

            return connection.json;
        }
    }
}
