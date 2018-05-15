using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class APIItem : ConnectionAPI
    {
        public APIItem(string parameter, string region,
            string link) : base(APIKey.GetKey(), parameter, region, link) { }

        public APIItem(string region,
            string link) : base(APIKey.GetKey(), region, link) { }

        // Only return one Item
        // RETURN STRING
        public string GetData(string typeData)
        {
            return (string)jObject[typeData];
        }
    }
}
