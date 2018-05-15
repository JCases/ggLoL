using System.Collections.Generic;

namespace ggLoL
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

    public class FreeChampions
    {
        public List<FreeChampion> lFreeCham { get; set; }
    }
}
