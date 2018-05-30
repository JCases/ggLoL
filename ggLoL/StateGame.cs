using System.Collections.Generic;

namespace ggLoL
{
    public class StateGame
    {
        public string name { get; set; }
        public string region_tag { get; set; }
        public string hostname { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }
        public List<string> locales { get; set; }

        public struct Service
        {
            public string status;
            public List<Incident> incidents;
            public string name;
            public string slug;
        }

        public struct Incident
        {
            public bool active;
            public string created_at;
            public long id;
            public List<Message> updates;
        }

        public struct Message
        {
            public string severity;
            public string author;
            public string created_at;
            public List<Translation> translations;
            public string updated_at;
            public string content;
            public string id;
        }

        public struct Translation
        {
            public string locale;
            public string content;
            public string updated_at;
        }
    }
}
