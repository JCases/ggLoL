using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class APIObject : ConnectionAPI
    {
        public APIObject(string parameter, string region,
            string link) : base(APIKey.GetKey(), parameter, region, link) { }

        public APIObject(string region,
            string link) : base(APIKey.GetKey(), region, link) { }

        // Only return List of Objects
        // RETURN STRING
        public JObject GetData()
        {
            return jObject;
        }
    }
}
