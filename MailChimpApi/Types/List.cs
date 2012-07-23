using System;
using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// A list's details
    /// </summary>
    public class List
    {
        /// <summary>
        /// The list id for this list. This will be used for all other list management functions.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The list id used in our web app, allows you to create a link directly to it
        /// </summary>
        [JsonProperty(PropertyName = "web_id")]
        public int WebId { get; set; }

        /// <summary>
        /// The name of the list.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date that this list was created.
        /// </summary>
        [JsonProperty(PropertyName = "date_created")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Whether or not the List supports multiple formats for emails or just HTML
        /// </summary>
        [JsonProperty(PropertyName = "email_type_option")]
        public bool EmailTypeOption { get; set; }

        /// <summary>
        /// Whether or not campaigns for this list use the Awesome Bar in archives by default
        /// </summary>
        [JsonProperty(PropertyName = "use_awesomebar")]
        public bool UseAwesomeBar { get; set; }

        /// <summary>
        /// Default From Name for campaigns using this list
        /// </summary>
        [JsonProperty(PropertyName = "default_from_name")]
        public string DefaultFromName { get; set; }

        /// <summary>
        /// Default From Email for campaigns using this list
        /// </summary>
        [JsonProperty(PropertyName = "default_from_email")]
        public string DefaultFromEmail { get; set; }

        /// <summary>
        /// Default Subject Line for campaigns using this list
        /// </summary>
        [JsonProperty(PropertyName = "default_subject")]
        public string DefaultSubject { get; set; }

        /// <summary>
        /// Default Language for this list's forms
        /// </summary>
        [JsonProperty(PropertyName = "default_language")]
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// An auto-generated activity score for the list (0 - 5)
        /// </summary>
        [JsonProperty(PropertyName = "list_rating")]
        public int ListRating { get; set; }

        /// <summary>
        /// Our eepurl shortened version of this list's subscribe form (will not change)
        /// </summary>
        [JsonProperty(PropertyName = "subscribe_url_short")]
        public string SubscribeUrlShort { get; set; }

        /// <summary>
        /// The full version of this list's subscribe form (host will vary)
        /// </summary>
        [JsonProperty(PropertyName = "subscribe_url_long")]
        public string SubscribeUrlLong { get; set; }

        /// <summary>
        /// The email address to use for this list's Email Beamer
        /// </summary>
        [JsonProperty(PropertyName = "beamer_address")]
        public string BeamerAddress { get; set; }
        
        /// <summary>
        /// Whether this list is Public (pub) or Private (prv). Used internally for projects like Wavelength
        /// </summary>
        public string Visibility { get; set; }

        /// <summary>
        /// various stats and counts for the list - many of these are cached for at least 5 minutes
        /// </summary>
        public ListStats Stats { get; set; }

        /// <summary>
        /// Any list specific modules installed for this list (example is SocialPro)
        /// </summary>
        public object[] Modules { get; set; }
    }
}