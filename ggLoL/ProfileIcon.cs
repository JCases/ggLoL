using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class ProfileIcon
    {
        public ProfileIconDataDto profileIcon { get; set; }

        public static string GetLink()
        {
            return "lol/static-data/v3/profile-icons";
        }

        private const string fileName = "profileIcons.json";

        public void Save(ProfileIcon c)
        {
            string profileIcons = JsonConvert.SerializeObject(c);
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(profileIcons);
            writer.Close();
        }

        public ProfileIcon Load()
        {
            StreamReader reader = new StreamReader(fileName);
            string profileIcons = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<ProfileIcon>(profileIcons);
        }

        public struct ProfileIconDataDto
        {
            public Dictionary<string, ProfileIconDetailsDto> data;
            public string version;
            public string type;
        }

        public struct ProfileIconDetailsDto
        {
            public ImageDto image;
            public long id;
        }

        public struct ImageDto
        {
            public string full;
            public string group;
            public string sprite;
            public int h;
            public int w;
            public int x;
            public int y;
        }
    }
}
