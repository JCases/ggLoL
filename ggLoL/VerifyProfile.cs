using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ggLoL
{
    abstract class VerifyProfile : User
    {
        public string key { get; set; }
        const int keyLenght = 8; 

        public VerifyProfile(string name, string password, string email, 
            string nick, bool verify) : 
            base(name, password, email, nick, verify) { }

        private static string RandomString()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, keyLenght)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string CreateKey() { return RandomString(); }

        public static bool SearchKey(string nick)
        {
            try
            {
                ConnectionAPI connection =
                    new ConnectionAPI(nick, APILinks.GetLink(
                    APILinks.Link.VerifyProfile));

                string key = JsonConvert.DeserializeObject<string>(connection.json);

                return true;
            }
            catch { MessageBox.Show("Summoner don't found!"); return false; }
        }

    }
}
