namespace RDumont.MailChimpApi.Types
{
    public class MailChimpArray<T>
    {
        public int Total { get; set; }
        public T[] Data { get; set; }
    }
}
