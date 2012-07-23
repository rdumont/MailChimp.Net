using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    /// <summary>
    /// various stats and counts for the list - many of these are cached for at least 5 minutes
    /// </summary>
    public class ListStats
    {
        /// <summary>
        /// The number of active members in the given list.
        /// </summary>
        [JsonProperty(PropertyName = "web_id")]
        public int MemberCount { get; set; }

        /// <summary>
        /// The number of members who have unsubscribed from the given list.
        /// </summary>
        [JsonProperty(PropertyName = "unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        /// <summary>
        /// The number of members cleaned from the given list.
        /// </summary>
        [JsonProperty(PropertyName = "cleaned_count")]
        public int CleanedCount { get; set; }

        /// <summary>
        /// The number of active members in the given list since the last campaign was sent
        /// </summary>
        [JsonProperty(PropertyName = "member_count_since_send")]
        public int MemberCountSinceSend { get; set; }

        /// <summary>
        /// The number of members who have unsubscribed from the given list since the last campaign was sent
        /// </summary>
        [JsonProperty(PropertyName = "unsubscribe_count_since_send")]
        public int UnsubscribeCountSinceSend { get; set; }

        /// <summary>
        /// The number of members cleaned from the given list since the last campaign was sent
        /// </summary>
        [JsonProperty(PropertyName = "cleaned_count_since_send")]
        public int CleanedCountSinceSend { get; set; }

        /// <summary>
        /// The number of campaigns in any status that use this list
        /// </summary>
        [JsonProperty(PropertyName = "campaign_count")]
        public int CampaignCount { get; set; }

        /// <summary>
        /// The number of Interest Groupings for this list
        /// </summary>
        [JsonProperty(PropertyName = "grouping_count")]
        public int GroupingCount { get; set; }

        /// <summary>
        /// The number of Interest Groups (regardless of grouping) for this list
        /// </summary>
        [JsonProperty(PropertyName = "group_count")]
        public int GroupCount { get; set; }

        /// <summary>
        /// The number of merge vars for this list (not including the required EMAIL one)
        /// </summary>
        [JsonProperty(PropertyName = "merge_var_count")]
        public int MergeVarCount { get; set; }

        /// <summary>
        /// the average number of subscribe per month for the list (empty value if we haven't calculated this yet)
        /// </summary>
        [JsonProperty(PropertyName = "avg_sub_rate")]
        public int? AvgSubRate { get; set; }

        /// <summary>
        /// the average number of unsubscribe per month for the list (empty value if we haven't calculated this yet)
        /// </summary>
        [JsonProperty(PropertyName = "avg_unsub_rate")]
        public int? AvgUnsubRate { get; set; }

        /// <summary>
        /// the target subscription rate for the list to keep it growing (empty value if we haven't calculated this yet)
        /// </summary>
        [JsonProperty(PropertyName = "target_sub_rate")]
        public int? TargetSubRate { get; set; }

        /// <summary>
        /// the average open rate per campaign for the list (empty value if we haven't calculated this yet)
        /// </summary>
        [JsonProperty(PropertyName = "open_rate")]
        public int? OpenRate { get; set; }

        /// <summary>
        /// the average click rate per campaign for the list (empty value if we haven't calculated this yet)
        /// </summary>
        [JsonProperty(PropertyName = "click_rate")]
        public int? ClickRate { get; set; }
    }
}