using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class ggLoLMain
    {
        protected Champions champions { get; set; }
        protected string region;

        protected bool online { get; }

        public ggLoLMain()
        {
            /*
            this.region = "euw1";

            APIObject connection = new APIObject(region, Champions.GetLink());
            Champions champions =
                JsonConvert.DeserializeObject<Champions>(connection.json);
            this.champions = champions;
            */
        }
    }
}
