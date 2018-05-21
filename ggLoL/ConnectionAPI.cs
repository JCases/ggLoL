using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ggLoL
{
    public class ConnectionAPI : ggLoLMain
    {
        private Stream stream;
        private string key = APIKey.GetKey();
        
        public string json { get; set; }

        // If you need a parameter
        public ConnectionAPI(string parameter, string link)
        {
            try
            {
                WebClient client = new WebClient();
                
                if (parameter.Length == 0)
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link + parameter + "?api_key=" + key);
                else
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link + "?" + parameter + "&api_key=" + key);

                // Show Link - DELETE IN FINAL VERSION - TO DO
                MessageBox.Show("https://" + region + ".api.riotgames.com/"
                    + link + "?" + parameter + "?api_key=" + key);

                StreamReader reader = new StreamReader(stream);

                json = reader.ReadToEnd();

                reader.Close();
                stream.Close();
            }
            catch (Exception)
            { 
                // Show Link - DELETE IN FINAL VERSION - TO DO
                MessageBox.Show("https://" + region + ".api.riotgames.com/"
                    + link + "?" + parameter + "?api_key=" + key + "CATCH DETECTED PROBLEMS!");
            }
        }

        // If you don't need a parameter
        public ConnectionAPI(string link) : 
            this("", link) { }
    }
}
