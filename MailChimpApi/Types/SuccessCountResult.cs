using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// Array of result counts and any errors that occurred
    /// </summary>
    public class SuccessCountResult
    {
        /// <summary>
        /// Number of items addresses that were succesful
        /// </summary>
        [JsonProperty(PropertyName = "success_count")]
        public int SuccessCount { get; set; }

        /// <summary>
        /// Number of items that failed
        /// </summary>
        [JsonProperty(PropertyName = "error_count")]
        public int ErrorCount { get; set; }
        
        /// <summary>
        /// Error details
        /// </summary>
        public EmailError Errors { get; set; }
    }
}