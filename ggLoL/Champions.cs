using System.Collections.Generic;

namespace ggLoL
{
    public class Champions
    {
        public List<Champion> listChamp { get; set; }

        public Champions()
        {
            listChamp = new List<Champion>();
        }

        public static string GetLink()
        {
            return "lol/static-data/v3/champions";
        }
    }
}
