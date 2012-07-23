namespace RDumont.MailChimpApi
{
    /// <summary>
    /// MailChimp API v1.3 client interface
    /// </summary>
    public interface IMailChimpClient
    {
        /// <summary>
        /// The full API key used for this client
        /// </summary>
        string ApiKey { get; }

        /// <summary>
        /// The server used for this client
        /// </summary>
        string Dc { get; }

        /// <summary>
        /// List Related Methods
        /// </summary>
        IListsApi Lists { get; }

        /// <summary>
        /// Makes a generic POST call to the API. Prefer using the already implemented methods, so use this at your own risk.
        /// </summary>
        /// <typeparam name="TResult">The result type of the API call</typeparam>
        /// <param name="method">The name of the method being called</param>
        /// <param name="data">Data send in JSON</param>
        /// <returns>The method's specific return</returns>
        TResult GenericCall<TResult>(string method, object data = null);
    }
}