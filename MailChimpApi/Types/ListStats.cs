using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    public class ListStats
    {
        [JsonProperty(PropertyName = "web_id")]
        public int MemberCount { get; set; }

        [JsonProperty(PropertyName = "unsubscribe_count")]
        public int UnsubscribeCount { get; set; }

        [JsonProperty(PropertyName = "cleaned_count")]
        public int CleanedCount { get; set; }

        [JsonProperty(PropertyName = "member_count_since_send")]
        public int MemberCountSinceSend { get; set; }

        [JsonProperty(PropertyName = "unsubscribe_count_since_send")]
        public int UnsubscribeCountSinceSend { get; set; }

        [JsonProperty(PropertyName = "cleaned_count_since_send")]
        public int CleanedCountSinceSend { get; set; }

        [JsonProperty(PropertyName = "campaign_count")]
        public int CampaignCount { get; set; }

        [JsonProperty(PropertyName = "grouping_count")]
        public int GroupingCount { get; set; }

        [JsonProperty(PropertyName = "group_count")]
        public int GroupCount { get; set; }

        [JsonProperty(PropertyName = "merge_var_count")]
        public int MergeVarCount { get; set; }

        [JsonProperty(PropertyName = "avg_sub_rate")]
        public int? AvgSubRate { get; set; }

        [JsonProperty(PropertyName = "avg_unsub_rate")]
        public int? AvgUnsubRate { get; set; }

        [JsonProperty(PropertyName = "target_sub_rate")]
        public int? TargetSubRate { get; set; }

        [JsonProperty(PropertyName = "open_rate")]
        public int? OpenRate { get; set; }

        [JsonProperty(PropertyName = "click_rate")]
        public int? ClickRate { get; set; }
    }
}