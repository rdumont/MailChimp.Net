namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// An array of a given MailChimp API type
    /// </summary>
    /// <typeparam name="T">Type of the array</typeparam>
    public class MailChimpArray<T>
    {
        /// <summary>
        /// The total number of Ts
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// The items
        /// </summary>
        public T[] Data { get; set; }
    }
}
