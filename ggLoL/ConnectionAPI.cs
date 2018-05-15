using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ggLoL
{
    abstract public class ConnectionAPI : ggLoLMain
    {
        protected Stream stream;
        protected WebClient client;
        protected StreamReader reader;
        
        public string json { get; set; }

        protected string apiKey;

        // If you need a parameter
        public ConnectionAPI(string apiKey, string parameter, string link)
        {
            try
            {

                this.apiKey = apiKey;

                client = new WebClient();

                stream = client.OpenRead("https://" + region + ".api.riotgames.com"
                    + link + parameter + "?api_key=" + apiKey);

                reader = new StreamReader(stream);

                // CHANGE TO READ TO END IN STRING "JSON"
                json = reader.ReadToEnd();

                reader.Close();
                stream.Close();
            }
            catch (Exception) { }
        }

        // If you don't need a parameter
        public ConnectionAPI(string apiKey, string link) : 
            this(apiKey, "", link) { }
    }
}
