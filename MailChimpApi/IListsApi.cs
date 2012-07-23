using RDumont.MailChimpApi.Types;

namespace RDumont.MailChimpApi
{
    public interface IListsApi
    {
        bool Subscribe(string id, string emailAddress, object mergeVars = null,
            string emailType = "html", bool doubleOptin = true, bool updateExisting = false,
            bool replaceInterests = true, bool sendWelcome = false);

        BatchSubscribeResult BatchSubscribe(string id, object[] batch, bool doubleOptin = true,
            bool updateExisting = false, bool replaceInterests = true);

        bool Unsubscribe(string id, string emailAddress, bool deleteMember = false, bool sendGoodbye = true, bool sendNotify = true);
        bool UpdateMember(string id, string emailAddress, object mergeVars, string emailType = "", bool replaceInterests = true);
        MailChimpArray<List> Lists();
    }
}