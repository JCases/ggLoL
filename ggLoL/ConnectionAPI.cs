using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class ConnectionAPI : ggLoLMain
    {
        protected Stream stream { get; set; }
        private string key = APIKey.GetKey();
        
        public string json { get; set; }

        // If you need a parameter
        public ConnectionAPI(string parameter, string link)
        {
            try
            {
                WebClient client = new WebClient();

                if (parameter != "")
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com"
                        + link + parameter + "&api_key=" + key);
                else
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com"
                        + link + parameter + "?api_key=" + key);

                StreamReader reader = new StreamReader(stream);

                json = reader.ReadToEnd();

                reader.Close();
            }
            catch (Exception) { }
        }

        // If you don't need a parameter
        public ConnectionAPI(string link) : 
            this("", link) { }

        public void Disconnect()
        {
            stream.Close();
        }
    }
}
