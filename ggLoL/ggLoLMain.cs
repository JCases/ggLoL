using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class ggLoLMain
    {
        protected Champions champions { get; set; }
        protected string region;

        public ggLoLMain()
        {
            this.region = "euw1";

            const string link = "/lol/summoner/v3/champions";

            APIObject connection = new APIObject(region, link);
            Champions champions =
                JsonConvert.DeserializeObject<Champions>(connection.json);
            this.champions = champions;
        }
    }
}
