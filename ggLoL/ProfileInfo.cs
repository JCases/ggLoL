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

        const string link = "/lol/summoner/v3/summoners/by-name/";

        public ProfileInfo(string name, string region)
        {
            APIItem item = new APIItem(name, region, link);
            profileIconId = Convert.ToInt32(item.GetData("profileIconId"));
            name = item.GetData("name");
            summonerLevel = Convert.ToInt64(item.GetData("summonerLevel"));
            revisionDate = Convert.ToInt64(item.GetData("revisionDate"));
            id = Convert.ToInt64(item.GetData("id"));
            accountId = Convert.ToInt64(item.GetData("accountId"));
        }
    }
}
