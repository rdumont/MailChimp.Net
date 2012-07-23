using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RDumont.MailChimpApi.Types
{
    public class BatchSubscribeResult
    {
        [JsonProperty(PropertyName = "add_count")]
        public int AddCount { get; set; }

        [JsonProperty(PropertyName = "update_count")]
        public int UpdateCount { get; set; }

        [JsonProperty(PropertyName = "error_count")]
        public int ErrorCount { get; set; }

        public BatchSubscribeError[] Errors { get; set; }
    }
}
