using System;
using System.Collections.Generic;

namespace ggLoL
{
    class Map
    {
        struct MapDataDto
        {
            Dictionary<string,MapDetailsDto> data;
            string version;
            string type;
        }

        struct MapDetailsDto
        {
            string mapName;
            ImageDto image;
            long mapId;
            List<long> unpurchasableItemList;
        }

        struct ImageDto
        {
            string full;
            string group;
            string sprite;
            int h;
            int w;
            int y;
            int x;
        }
    }
}
