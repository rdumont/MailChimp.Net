using System;
using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    public class List
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "web_id")]
        public int WebId { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty(PropertyName = "email_type_option")]
        public bool EmailTypeOption { get; set; }

        [JsonProperty(PropertyName = "use_awesomebar")]
        public bool UseAwesomeBar { get; set; }

        [JsonProperty(PropertyName = "default_from_name")]
        public string DefaultFromName { get; set; }

        [JsonProperty(PropertyName = "default_from_email")]
        public string DefaultFromEmail { get; set; }

        [JsonProperty(PropertyName = "default_subject")]
        public string DefaultSubject { get; set; }

        [JsonProperty(PropertyName = "default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty(PropertyName = "list_rating")]
        public int ListRating { get; set; }

        [JsonProperty(PropertyName = "subscribe_url_short")]
        public string SubscribeUrlShort { get; set; }

        [JsonProperty(PropertyName = "subscribe_url_long")]
        public string SubscribeUrlLong { get; set; }

        [JsonProperty(PropertyName = "beamer_address")]
        public string BeamerAddress { get; set; }

        public string Visibility { get; set; }

        public ListStats Stats { get; set; }

        public object[] Modules { get; set; }
    }
}