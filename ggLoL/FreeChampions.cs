using System.Collections.Generic;

namespace ggLoL
{
    public class FreeChampions
    {
        public struct FreeChampion
        {
            public bool rankedPlayEnabled;
            public bool botEnabled;
            public bool botMmEnabled;
            public bool active;
            public bool freeToPlay;
            public long id;
        }

        public List<FreeChampion> lFreeCham { get; set; }

        public FreeChampions()
        {
            lFreeCham = new List<FreeChampion>();
        }

        public static string GetLink() { return "lol/platform/v3/champions"; }
    }
}
