using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.Create
{
    public class ThreadCreateResponse
    {
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        [JsonProperty(PropertyName = "reactions")]
        public int Reactions { get; set; }
        [JsonProperty(PropertyName = "identifiers")]
        public List<object> Identifiers { get; set; }
        [JsonProperty(PropertyName = "forum")]
        public string Forum { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "dislikes")]
        public int Dislikes { get; set; }
        [JsonProperty(PropertyName = "isDeleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }
        [JsonProperty(PropertyName = "userScore")]
        public int UserScore { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "isClosed")]
        public bool IsClosed { get; set; }
        [JsonProperty(PropertyName = "posts")]
        public int Posts { get; set; }
        [JsonProperty(PropertyName = "link")]
        public object Link { get; set; }
        [JsonProperty(PropertyName = "likes")]
        public int Likes { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; set; }
    }
}
