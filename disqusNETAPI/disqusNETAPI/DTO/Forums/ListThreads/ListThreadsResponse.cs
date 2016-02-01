using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Forums.ListThreads
{
    public class ListThreadsResponse
    {
        [JsonProperty(PropertyName = "category")]
        public string category { get; set; }
        [JsonProperty(PropertyName = "reactions")]
        public int reactions { get; set; }
        [JsonProperty(PropertyName = "identifiers")]
        public List<object> identifiers { get; set; }
        [JsonProperty(PropertyName = "forum")]
        public string forum { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }
        [JsonProperty(PropertyName = "dislikes")]
        public int dislikes { get; set; }
        [JsonProperty(PropertyName = "isDeleted")]
        public bool isDeleted { get; set; }
        [JsonProperty(PropertyName = "author")]
        public string author { get; set; }
        [JsonProperty(PropertyName = "userScore")]
        public int userScore { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "isClosed")]
        public bool isClosed { get; set; }
        [JsonProperty(PropertyName = "posts")]
        public int posts { get; set; }
        [JsonProperty(PropertyName = "link")]
        public object link { get; set; }
        [JsonProperty(PropertyName = "likes")]
        public int likes { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string message { get; set; }
        [JsonProperty(PropertyName = "ipAddress")]
        public string ipAddress { get; set; }
        [JsonProperty(PropertyName = "slug")]
        public string slug { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public string createdAt { get; set; }
    }
}
