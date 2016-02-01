using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.ListPosts
{
    public class ListPostsResponse
    {
        [JsonProperty(PropertyName = "isJuliaFlagged")]
        public bool isJuliaFlagged { get; set; }
        [JsonProperty(PropertyName = "isFlagged")]
        public bool isFlagged { get; set; }
        [JsonProperty(PropertyName = "forum")]
        public string forum { get; set; }
        [JsonProperty(PropertyName = "parent")]
        public int? parent { get; set; }
        [JsonProperty(PropertyName = "author")]
        public ListPostsAuthor author { get; set; }
        [JsonProperty(PropertyName = "media")]
        public List<object> media { get; set; }
        [JsonProperty(PropertyName = "isApproved")]
        public bool isApproved { get; set; }
        [JsonProperty(PropertyName = "dislikes")]
        public int dislikes { get; set; }
        [JsonProperty(PropertyName = "raw_message")]
        public string raw_message { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "threads")]
        public string thread { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int points { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public string createdAt { get; set; }
        [JsonProperty(PropertyName = "isEdited")]
        public bool isEdited { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string message { get; set; }
        [JsonProperty(PropertyName = "isHighligted")]
        public bool isHighlighted { get; set; }
        [JsonProperty(PropertyName = "ipAddress")]
        public string ipAddress { get; set; }
        [JsonProperty(PropertyName = "isSpam")]
        public bool isSpam { get; set; }
        [JsonProperty(PropertyName = "isDeleted")]
        public bool isDeleted { get; set; }
        [JsonProperty(PropertyName = "likes")]
        public int likes { get; set; }
    }
}
