namespace ggLoL
{
    abstract public class Region
    {
        public static string linkRegion { get; set; }

        public static void SetRegion(string region)
        {
            switch(region.ToUpper())
            {
                case "BR":
                    linkRegion = "br1";
                    break;
                case "EUNE":
                    linkRegion = "eun1";
                    break;
                case "EUW":
                    linkRegion = "euw1";
                    break;
                case "JP":
                    linkRegion = "jp1";
                    break;
                case "KR":
                    linkRegion = "kr";
                    break;
                case "LAN":
                    linkRegion = "la1";
                    break;
                case "LAS":
                    linkRegion = "la2";
                    break;
                case "NA":
                    linkRegion = "na1";
                    break;
                case "OCE":
                    linkRegion = "oc1";
                    break;
                case "TR":
                    linkRegion = "tr1";
                    break;
                case "RU":
                    linkRegion = "ru";
                    break;
                case "PBE":
                    linkRegion = "pbe1";
                    break;
            }
        }
    }
}
