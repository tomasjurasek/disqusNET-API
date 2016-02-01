using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Forums.ListThreads
{
    public class ListThreadsCursor
    {
        [JsonProperty(PropertyName = "prev")]
        public object Prev { get; set; }
        [JsonProperty(PropertyName = "hasNext")]
        public bool HasNext { get; set; }
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }
        [JsonProperty(PropertyName = "hasPrev")]
        public bool HasPrev { get; set; }
        [JsonProperty(PropertyName = "total")]
        public object Total { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "more")]
        public bool More { get; set; }
    }
}
