using System.Collections.Generic;

namespace ggLoL
{
    public class Champions
    {
        public List<Champion> listChamp { get; set; }

        public static string GetLink()
        {
            return "/lol/summoner/v3/champions";
        }
    }
}
