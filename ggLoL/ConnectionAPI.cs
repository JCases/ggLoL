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

                // Show Link - DELETE IN FINAL VERSION - TO DO
                if (parameter.Length == 0)
                {
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link  + "?api_key=" + key);
                    MessageBox.Show("https://" + region + ".api.riotgames.com/"
                        + link + "?api_key=" + key);
                }   
                else
                {
                    stream = client.OpenRead("https://" + region + ".api.riotgames.com/"
                        + link + parameter + "&api_key=" + key);
                    MessageBox.Show("https://" + region + ".api.riotgames.com/"
                        + link + parameter + "&api_key=" + key);
                }

                StreamReader reader = new StreamReader(stream);

                json = reader.ReadToEnd();

                MessageBox.Show(json);

                reader.Close();
                stream.Close();
            }
            catch (Exception) { }
        }

        // If you don't need a parameter
        public ConnectionAPI(string link) : 
            this("", link) { }
    }
}
