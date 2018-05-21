namespace ggLoL
{
    public class LinksAPI
    {
        public enum Link : int
        {
            Champions = 0,
            FreeChampions = 1,
            SummonerProfile = 2,
            Maps = 3,
            Spells = 4,
            Items = 5,
            ProfileIcon = 6,
            Runes = 7,
            ChampionMastery = 8,
            VerifyProfile = 9,
            DragontailData = 10
        };

        public static string GetLinksAPI(Link n)
        {
            string[] link = {
                "lol/static-data/v3/champions",
                "lol/platform/v3/champions",
                "lol/summoner/v3/summoners/by-name/",
                "lol/static-data/v3/maps",
                "lol/static-data/v3/summoner-spells",
                "lol/static-data/v3/items",
                "lol/static-data/v3/profile-icons",
                "lol/static-data/v3/reforged-runes",
                "lol/static-data/v3/champion-masteries/by-summoner/",
                "lol/platform/v3/third-party-code/by-summoner/",
                "lol/static-data/v3/tarball-links"};

            return link[(int)n];
        }
    }
}
