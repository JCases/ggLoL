using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ggLoL
{
    abstract public class ggLoLMain
    {
        protected static string region { get; set; }

        public static bool online { get; set; }

        private static string json { get; set; }

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
                s = null;
                if (online)
                {
                    ConnectionAPI connection =
                        new ConnectionAPI(name, APILinks.GetLink(
                        APILinks.Link.SummonerProfile), true);

                    json = connection.json;
                }
                else
                    GetOfflineData(name.ToLower() + "-" + Region.linkRegion.ToLower() +
                        SummonerProfile.fileName);

                s = JsonConvert.DeserializeObject<SummonerProfile>(json);

                json = null;

                return true;
            }
            catch
            {
                s = null;
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Non-Existing Summoner Profile");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Perfil de Invocador no Existente");
                return false;
            }
        }

        public static bool SearchChampion(out Champions c)
        {
            c = null;
            try
            {
                if (online)
                {
                    ConnectionAPI connection =
                        new ConnectionAPI(APILinks.GetLink(
                        APILinks.Link.Champions), true);

                    json = connection.json;
                }
                else
                    GetOfflineData(Champions.fileName);

                c = JsonConvert.DeserializeObject<Champions>(json);

                json = null;

                return true;
            }
            catch
            {
                c = null;
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Non-Existing Champion");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Campeón no Existente");
                return false;
            }
        }

        public static bool SearchGameInfo(out Items i)
        {
            i = null;
            try
            {
                if (online)
                {
                    ConnectionAPI connection =
                        new ConnectionAPI(APILinks.GetLink(
                        APILinks.Link.Items), true);

                    json = connection.json;
                }
                else
                    GetOfflineData(Items.fileName);


                i = JsonConvert.DeserializeObject<Items>(json);

                json = null;

                return true;
            }
            catch
            {
                i = null;
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Non-Existing Object");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Objeto no Existente");
                return false;
            }
        }

        // For Download File Data
        public static bool GetLinkFileData(out string link)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(APILinks.Link.DragontailData), false);

                json = connection.json;

                link = JsonConvert.DeserializeObject<string>(json);

                json = null;

                return true;
            }
            catch

            {
                link = null;
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Connection error");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Error en la Conexión");
                return false;
            }   
        }

        public static bool StateLoL(out StateGame st)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(APILinks.GetLink(
                    APILinks.Link.StateLoL), false);

                json = connection.json;

                st = JsonConvert.DeserializeObject<StateGame>(json);

                json = null;

                return true;
            }
            catch
            {
                st = null;
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Connection error");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Error en la Conexión");
                return false;
            }
        }

        private static void GetOfflineData(string fileName)
        {
            if (!File.Exists(fileName))
            {
                if (ggLoL.language == "en-EN")
                    MessageBox.Show("Non-Existing Local Files");
                else if (ggLoL.language == "es-ES")
                    MessageBox.Show("Información no guardada localmente");
            }
            else
            {
                StreamReader reader = new StreamReader(fileName);
                json = reader.ReadToEnd();
                reader.Close();
            }
        }
    }
}
