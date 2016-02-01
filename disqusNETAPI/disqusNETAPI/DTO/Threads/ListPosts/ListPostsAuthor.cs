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
        public string Username { get; set; }
        [JsonProperty(PropertyName = "about")]
        public string About { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "isFollowing")]
        public bool IsFollowing { get; set; }
        [JsonProperty(PropertyName = "isFollowedBy")]
        public bool IsFollowedBy { get; set; }
        [JsonProperty(PropertyName = "profileUrl")]
        public string ProfileUrl { get; set; }
        [JsonProperty(PropertyName = "avatar")]
        public ListPostsAvatar Avatar { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "isAnonymous")]
        public bool IsAnonymous { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}
