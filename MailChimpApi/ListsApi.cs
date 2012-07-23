using RDumont.MailChimpApi.Types;

namespace RDumont.MailChimpApi
{
    public class ListsApi
    {
        private readonly MailChimpClient _client;

        public ListsApi(MailChimpClient client)
        {
            _client = client;
        }

        public bool Subscribe(string id, string emailAddress, object mergeVars = null,
            string emailType = "html", bool doubleOptin = true, bool updateExisting = false,
            bool replaceInterests = true, bool sendWelcome = false)
        {
            var data = new
                {
                    id,
                    email_address = emailAddress,
                    merge_vars = mergeVars ?? new {},
                    email_type = emailType,
                    double_optin = doubleOptin,
                    update_existing = updateExisting,
                    replace_interests = replaceInterests,
                    send_welcome = sendWelcome
                };

            return _client.GenericCall<bool>("listSubscribe", data);
        }

        public bool Unsubscribe(string id, string emailAddress, bool deleteMember = false, bool sendGoodbye = true, bool sendNotify = true)
        {
            var data = new
                {
                    id,
                    email_address = emailAddress,
                    delete_member = deleteMember,
                    send_goodbye = sendGoodbye,
                    send_notify = sendNotify
                };

            return _client.GenericCall<bool>("listUnsubscribe", data);
        }

        public bool UpdateMember(string id, string emailAddress, object mergeVars, string emailType = "", bool replaceInterests = true)
        {
            var data = new
                {
                    id,
                    email_address = emailAddress,
                    merge_vars = mergeVars,
                    email_type = emailType,
                    replace_interests = replaceInterests
                };

            return _client.GenericCall<bool>("listUpdateMember", data);
        }

        public MailChimpArray<List> Lists()
        {
            return _client.GenericCall<MailChimpArray<List>>("lists");
        }
    }
}