using System.Collections.Generic;

namespace ggLoL
{
    public class StateChampions
    {
        public List<ChampionDto> champions { get; set; }

        public struct ChampionDto
        {
            public bool rankedPlayEnabled { get; set; }
            public bool botEnabled { get; set; }
            public bool botMmEnabled { get; set; }
            public bool active { get; set; }
            public bool freeToPlay { get; set; }
            public long id { get; set; }
        }
    }

    
}
