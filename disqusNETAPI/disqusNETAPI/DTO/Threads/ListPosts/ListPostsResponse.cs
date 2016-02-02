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
        public ListPostsResponse()
        {
            Children = new List<ListPostsResponse>();
        }
        [JsonProperty(PropertyName = "isJuliaFlagged")]
        public bool IsJuliaFlagged { get; set; }
        [JsonProperty(PropertyName = "isFlagged")]
        public bool IsFlagged { get; set; }
        [JsonProperty(PropertyName = "forum")]
        public string Forum { get; set; }
        [JsonProperty(PropertyName = "parent")]
        public string Parent { get; set; }
        [JsonProperty(PropertyName = "author")]
        public ListPostsAuthor Author { get; set; }
        [JsonProperty(PropertyName = "media")]
        public List<object> Media { get; set; }
        [JsonProperty(PropertyName = "isApproved")]
        public bool IsApproved { get; set; }
        [JsonProperty(PropertyName = "dislikes")]
        public int Dislikes { get; set; }
        [JsonProperty(PropertyName = "raw_message")]
        public string RawMessage { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "threads")]
        public string Thread { get; set; }
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; set; }
        [JsonProperty(PropertyName = "isEdited")]
        public bool IsEdited { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "isHighligted")]
        public bool IsHighlighted { get; set; }
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        [JsonProperty(PropertyName = "isSpam")]
        public bool IsSpam { get; set; }
        [JsonProperty(PropertyName = "isDeleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty(PropertyName = "likes")]
        public int Likes { get; set; }

        public List<ListPostsResponse> Children { get; set; }
    }
}
