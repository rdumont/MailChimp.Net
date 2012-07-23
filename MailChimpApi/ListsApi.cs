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

        public MailChimpArray<List> Lists()
        {
            return _client.GenericCall<MailChimpArray<List>>("lists");
        }

        public bool Subscribe(object id, string emailAddress, object mergeVars = null,
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
    }
}