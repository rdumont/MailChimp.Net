using System;

namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// Exception thrown due to an error in a MailChimp API call
    /// </summary>
    public class MailChimpException : Exception
    {
        /// <summary>
        /// The error code
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// Creates an instance based on a given API error
        /// </summary>
        /// <param name="error">The API error</param>
        public MailChimpException(ApiError error) : base(error.Error)
        {
            Code = error.Code;
        }
    }

    /// <summary>
    /// Error in a MailChimp API call
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// The error code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The full message
        /// </summary>
        public string Error { get; set; }
    }
}
