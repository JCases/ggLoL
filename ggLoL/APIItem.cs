using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class APIItem : ConnectionAPI
    {
        public APIItem(string parameter, string link) 
            : base(APIKey.GetKey(), parameter, link) { }

        public APIItem( string link) : base(APIKey.GetKey(), link) { }
    }
}
