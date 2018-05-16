using Newtonsoft.Json.Linq;

namespace ggLoL
{
    public class APIObject : ConnectionAPI
    {
        public APIObject(string parameter, string link) 
            : base(parameter, link) { }

        public APIObject(string link) : base("", link) { }
    }
}
