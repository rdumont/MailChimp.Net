namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// Error details
    /// </summary>
    public class BatchSubscribeError
    {
        /// <summary>
        /// address the email address in question
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the error code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// the full error message
        /// </summary>
        public string Message { get; set; }
    }
}