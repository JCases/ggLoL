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
            Region.SetRegion(txtRegion);
            region = Region.linkRegion;
        }

        public static bool SearchPlayer(string name, out SummonerProfile s)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(name, APILinks.GetLink(
                    APILinks.Link.SummonerProfile), true);

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
                    APILinks.Link.Champions), true);

                c = JsonConvert.DeserializeObject<Champions>(connection.json);

                return true;
            }
            catch { c = null; MessageBox.Show("Champion don't found!"); return false; }
        }

        public static bool SearchGameInfo(out Items i)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(
                    APILinks.Link.Items), true);

                i = JsonConvert.DeserializeObject<Items>(connection.json);

                return true;
            }
            catch { i = null; MessageBox.Show("Game Info don't found!"); return false; }
        }

        // For Download File Data
        public static bool GetLinkFileData(out string link)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(APILinks.Link.DragontailData), false);

                link = JsonConvert.DeserializeObject<string>(connection.json);

                return true;
            }
            catch { link = null; MessageBox.Show("Connection error"); return false; }   
        }

        public static bool StateLoL(out StateGame st)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(
                    APILinks.Link.StateLoL), false);

                st = JsonConvert.DeserializeObject<StateGame>(connection.json);

                return true;
            }
            catch { st = null; MessageBox.Show("Error in Connection"); return false; }
        }
    }
}
