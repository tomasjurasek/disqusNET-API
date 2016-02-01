using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.ListPosts
{
    public class ListPostsCursor
    {
        [JsonProperty(PropertyName = "prev")]
        public object prev { get; set; }
        [JsonProperty(PropertyName = "hasNext")]
        public bool hasNext { get; set; }
        [JsonProperty(PropertyName = "next")]
        public string next { get; set; }
        [JsonProperty(PropertyName = "hasPrev")]
        public bool hasPrev { get; set; }
        [JsonProperty(PropertyName = "total")]
        public object total { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "more")]
        public bool more { get; set; }
    }
}
