using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// Result counts and any errors that occurred
    /// </summary>
    public class BatchSubscribeResult
    {
        /// <summary>
        /// Number of email addresses that were succesfully added
        /// </summary>
        [JsonProperty(PropertyName = "add_count")]
        public int AddCount { get; set; }

        /// <summary>
        /// Number of email addresses that were succesfully updated
        /// </summary>
        [JsonProperty(PropertyName = "update_count")]
        public int UpdateCount { get; set; }

        /// <summary>
        /// Number of email addresses that failed during addition/updating
        /// </summary>
        [JsonProperty(PropertyName = "error_count")]
        public int ErrorCount { get; set; }

        /// <summary>
        /// Error details
        /// </summary>
        public BatchSubscribeError[] Errors { get; set; }
    }
}
