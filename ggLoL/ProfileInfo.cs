using System;

namespace ggLoL
{
    public class ProfileInfo
    {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public long summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountId { get; set; }

        public static string GetLink()
        {
            return "/lol/summoner/v3/summoners/by-name/";
        }
    }
}
