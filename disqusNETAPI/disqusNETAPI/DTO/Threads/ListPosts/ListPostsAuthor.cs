using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.ListPosts
{
    public class ListPostsAuthor
    {
        [JsonProperty(PropertyName = "username")]
        public string username { get; set; }
        [JsonProperty(PropertyName = "about")]
        public string about { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }
        [JsonProperty(PropertyName = "isFollowing")]
        public bool isFollowing { get; set; }
        [JsonProperty(PropertyName = "isFollowedBy")]
        public bool isFollowedBy { get; set; }
        [JsonProperty(PropertyName = "profileUrl")]
        public string profileUrl { get; set; }
        [JsonProperty(PropertyName = "avatar")]
        public ListPostsAvatar avatar { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "isAnonymous")]
        public bool isAnonymous { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }
    }
}
