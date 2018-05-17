using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ggLoL
{
    public class ggLoLMain
    {
        protected string region { get; set; }

        protected bool online { get; }

        public ggLoLMain()
        {
            online = true;

            region = "euw1";
        }

        public Champions GetListChampions()
        {
            ConnectionAPI connection =
                new ConnectionAPI(region, Champions.GetLink());
            Champions champions = new Champions();
            champions = 
                JsonConvert.DeserializeObject<Champions>(connection.json);
            return champions;
        }
    }
}
