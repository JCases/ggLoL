using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ggLoL
{
    abstract public class ConnectionAPI
    {
        protected Stream stream;
        protected WebClient client;
        protected StreamReader reader;
        // Delete
        protected JObject jObject;

        protected string apiKey;

        // If you need a parameter
        public ConnectionAPI(string apiKey, string parameter, string region, 
            string link)
        {
            this.apiKey = apiKey;

            client = new WebClient();

            stream = client.OpenRead("https://" + region + ".api.riotgames.com" 
                + link + parameter + "?api_key=" + apiKey);

            reader = new StreamReader(stream);
            
            // CHANGE TO READ TO END IN STRING "JSON"
            jObject = JObject.Parse(reader.ReadLine());

            reader.Close();
            stream.Close();
        }

        // FOR CREATE A OBJECT - OBJECT o = JsonConvert.DeserializeObject<Account>(connection.json)

        // If you don't need a parameter
        public ConnectionAPI(string apiKey, string region,
            string link) : this(apiKey, "", region, link) { }
    }
}
