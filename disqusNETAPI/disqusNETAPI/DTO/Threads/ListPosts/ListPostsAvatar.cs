using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.ListPosts
{
    public class ListPostsAvatar
    {
        [JsonProperty(PropertyName = "permalink")]
        public string permalink { get; set; }
        [JsonProperty(PropertyName = "cache")]
        public string cache { get; set; }
    }
}
