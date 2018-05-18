namespace ggLoL
{
    public class Region
    {
        public string linkRegion { get; set; }

        public Region(string region)
        {
            switch(region.ToUpper())
            {
                case "BR":
                    this.linkRegion = "BR1";
                    break;
                case "EUNE":
                    this.linkRegion = "EUN1";
                    break;
                case "EUW":
                    this.linkRegion = "EUW1";
                    break;
                case "JP":
                    this.linkRegion = "JP1";
                    break;
                case "KR":
                    this.linkRegion = "KR";
                    break;
                case "LAN":
                    this.linkRegion = "LA1";
                    break;
                case "LAS":
                    this.linkRegion = "LA2";
                    break;
                case "NA":
                    this.linkRegion = "NA1";
                    break;
                case "OCE":
                    this.linkRegion = "OC1";
                    break;
                case "TR":
                    this.linkRegion = "TR1";
                    break;
                case "RU":
                    this.linkRegion = "RU";
                    break;
                case "PBE":
                    this.linkRegion = "PBE1";
                    break;
            }
        }
    }
}
