using RDumont.MailChimpApi.Types;

namespace RDumont.MailChimpApi
{
    /// <summary>
    /// List Related Methods
    /// </summary>
    public interface IListsApi
    {
        /// <summary>
        /// Subscribe the provided email to a list. By default this sends a confirmation email - you will not see new members until the link contained in it is clicked!
        /// </summary>
        /// <param name="id">the list id to connect to. Get by calling lists()</param>
        /// <param name="emailAddress">the email address to subscribe</param>
        /// <param name="mergeVars">optional - merges for the email (FNAME, LNAME, etc.). Note that a merge field can only hold up to 255 bytes. Also, there are a few "special" keys.</param>
        /// <param name="emailType">optional - email type preference for the email (html, text, or mobile)</param>
        /// <param name="doubleOptin">optional - flag to control whether a double opt-in confirmation message is sent. Abusing this may cause your account to be suspended.</param>
        /// <param name="updateExisting">optional - flag to control whether existing subscribers should be updated instead of throwing an error</param>
        /// <param name="replaceInterests">optional - flag to determine whether we replace the interest groups with the groups provided or we add the provided groups to the member's interest groups</param>
        /// <param name="sendWelcome">optional - if your double_optin is false and this is true, we will send your lists Welcome Email if this subscribe succeeds - this will *not* fire if we end up updating an existing subscriber. If double_optin is true, this has no effect.</param>
        /// <returns>true on success, false on failure</returns>
        bool Subscribe(string id, string emailAddress, object mergeVars = null,
            string emailType = "html", bool doubleOptin = true, bool updateExisting = false,
            bool replaceInterests = true, bool sendWelcome = false);

        /// <summary>
        /// Subscribe a batch of email addresses to a list at once.
        /// Maximum batch sizes vary based on the amount of data in each record, though you should cap them at 5k - 10k records, depending on your experience.
        /// These calls are also long, so be sure you increase your timeout values.
        /// </summary>
        /// <param name="id">the list id to connect to. Get by calling lists()</param>
        /// <param name="batch">an array of structs for each address to import with two special keys: "EMAIL" for the email address, and "EMAIL_TYPE" for the email type option (html, text, or mobile)</param>
        /// <param name="doubleOptin">flag to control whether to send an opt-in confirmation email</param>
        /// <param name="updateExisting">flag to control whether to update members that are already subscribed to the list or to return an error</param>
        /// <param name="replaceInterests">flag to determine whether we replace the interest groups with the updated groups provided, or we add the provided groups to the member's interest groups</param>
        /// <returns>Array of result counts and any errors that occurred</returns>
        BatchSubscribeResult BatchSubscribe(string id, object[] batch, bool doubleOptin = true,
            bool updateExisting = false, bool replaceInterests = true);

        /// <summary>
        /// Unsubscribe the given email address from the list
        /// </summary>
        /// <param name="id">the list id to connect to. Get by calling lists()</param>
        /// <param name="emailAddress">the email address to unsubscribe OR the email "id" returned from listMemberInfo, Webhooks, and Campaigns</param>
        /// <param name="deleteMember">flag to completely delete the member from your list instead of just unsubscribing</param>
        /// <param name="sendGoodbye">flag to send the goodbye email to the email address</param>
        /// <param name="sendNotify">flag to send the unsubscribe notification email to the address defined in the list email notification settings</param>
        /// <returns>true on success, false on failure</returns>
        bool Unsubscribe(string id, string emailAddress, bool deleteMember = false, bool sendGoodbye = true, bool sendNotify = true);

        /// <summary>
        /// Edit the email address, merge fields, and interest groups for a list member
        /// </summary>
        /// <param name="id">the list id to connect to. Get by calling lists()</param>
        /// <param name="emailAddress">the current email address of the member to update OR the "id" for the member returned from listMemberInfo, Webhooks, and Campaigns</param>
        /// <param name="mergeVars">array of new field values to update the member with. Se mergeVars in <see cref="Subscribe"/> method</param>
        /// <param name="emailType">optional - change the email type preference for the member ("html", "text", or "mobile"). Leave blank to keep the existing preference</param>
        /// <param name="replaceInterests">optional - flag to determine whether we replace the interest groups with the updated groups provided, or we add the provided groups to the member's interest groups</param>
        /// <returns>true on success, false on failure</returns>
        bool UpdateMember(string id, string emailAddress, object mergeVars, string emailType = "", bool replaceInterests = true);

        /// <summary>
        /// Retrieve all of the lists defined for your user account
        /// </summary>
        /// <returns>an array of list details</returns>
        MailChimpArray<List> Lists();
    }
}