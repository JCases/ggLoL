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
                    this.linkRegion = "br1";
                    break;
                case "EUNE":
                    this.linkRegion = "eun1";
                    break;
                case "EUW":
                    this.linkRegion = "euw1";
                    break;
                case "JP":
                    this.linkRegion = "jp1";
                    break;
                case "KR":
                    this.linkRegion = "kr";
                    break;
                case "LAN":
                    this.linkRegion = "la1";
                    break;
                case "LAS":
                    this.linkRegion = "la2";
                    break;
                case "NA":
                    this.linkRegion = "na1";
                    break;
                case "OCE":
                    this.linkRegion = "oc1";
                    break;
                case "TR":
                    this.linkRegion = "tr1";
                    break;
                case "RU":
                    this.linkRegion = "ru";
                    break;
                case "PBE":
                    this.linkRegion = "pbe1";
                    break;
            }
        }
    }
}
