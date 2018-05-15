using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class APIObject : ConnectionAPI
    {
        public APIObject(string parameter, string link) 
            : base(APIKey.GetKey(), parameter, link) { }

        public APIObject(string link) : base(APIKey.GetKey(), link) { }
    }
}
