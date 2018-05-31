using System;
using System.IO;
using System.Net;

namespace ggLoL
{
    public class ConnectionAPI : ggLoLMain
    {
        private Stream stream;
        private string key = APIKey.GetKey();
        
        public string json { get; set; }

        // If you need a parameter
        public ConnectionAPI(string parameter, string link, bool LoadScreen)
        {
            // Show Form for Loading
            if (LoadScreen)
            {
                LoadData ld = new LoadData();
                ld.ShowDialog();
            } 
            try
            {
                WebClient client = new WebClient();

                if (parameter.Length == 0)
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link  + "?api_key=" + key);
                else
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link + parameter + "?api_key=" + key);

                StreamReader reader = new StreamReader(stream);

                json = reader.ReadToEnd();

                reader.Close();
                stream.Close();
            }
            catch (Exception) { }
            // Close Form for Loading
        }

        // If you don't need a parameter
        public ConnectionAPI(string link, bool LoadScreen) :
            this("", link, LoadScreen)
        { }
    }
}
