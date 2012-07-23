using System;
using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    public class MailChimpArray<T>
    {
        public int Total { get; set; }
        public T[] Data { get; set; }
    }

    public class List
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "web_id")]
        public int WebId { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public DateTime DateCreated { get; set; }

        [JsonProperty(PropertyName = "email_type_option")]
        public bool EmailTypeOption { get; set; }

        [JsonProperty(PropertyName = "use_awesomebar")]
        public bool UseAwesomeBar { get; set; }

        [JsonProperty(PropertyName = "default_from_name")]
        public string DefaultFromName { get; set; }

        [JsonProperty(PropertyName = "default_from_email")]
        public string DefaultFromEmail { get; set; }

        [JsonProperty(PropertyName = "default_subject")]
        public string DefaultSubject { get; set; }

        [JsonProperty(PropertyName = "default_language")]
        public string DefaultLanguage { get; set; }

        [JsonProperty(PropertyName = "list_rating")]
        public int ListRating { get; set; }

        [JsonProperty(PropertyName = "subscribe_url_short")]
        public string SubscribeUrlShort { get; set; }

        [JsonProperty(PropertyName = "subscribe_url_long")]
        public string SubscribeUrlLong { get; set; }

        [JsonProperty(PropertyName = "beamer_address")]
        public string BeamerAddress { get; set; }

        public string Visibility { get; set; }

        public ListStats Stats { get; set; }

        public object[] Modules { get; set; }
    }

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
