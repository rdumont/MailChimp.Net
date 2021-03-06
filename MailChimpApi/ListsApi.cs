using System;
using RDumont.MailChimpApi.Types;

namespace RDumont.MailChimpApi
{
    /// <summary>
    /// List Related Methods implementation
    /// </summary>
    public class ListsApi : IListsApi
    {
        private readonly IMailChimpClient _client;

        /// <summary>
        /// Creates an instance based on a MailChimp client
        /// </summary>
        /// <param name="client"></param>
        public ListsApi(IMailChimpClient client)
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

        public BatchSubscribeResult BatchSubscribe(string id, object[] batch, bool doubleOptin = true,
            bool updateExisting = false, bool replaceInterests = true)
        {
            if (batch == null) throw new ArgumentNullException("batch");

            var data = new
                {
                    id,
                    batch,
                    double_optin = doubleOptin,
                    update_existing = updateExisting,
                    replace_interests = replaceInterests
                };

            return _client.GenericCall<BatchSubscribeResult>("listBatchSubscribe", data);
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

        public SuccessCountResult BatchUnsubscribe(string id, string[] emails, bool deleteMember = false, bool sendGoodbye = true, bool sendNotify = false)
        {
            var data = new
                {
                    id,
                    emails,
                    delete_member = deleteMember,
                    send_goodbye = sendGoodbye,
                    send_notify = sendNotify
                };

            return _client.GenericCall<SuccessCountResult>("listBatchUnsubscribe", data);
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