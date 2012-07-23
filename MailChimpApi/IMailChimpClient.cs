namespace RDumont.MailChimpApi
{
    public interface IMailChimpClient
    {
        string ApiKey { get; }
        string Dc { get; }
        IListsApi Lists { get; }
        TResult GenericCall<TResult>(string method, object data = null);
    }
}