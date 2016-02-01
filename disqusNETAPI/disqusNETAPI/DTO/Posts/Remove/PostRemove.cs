using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Posts.Remove
{
    public class PostRemove
    {
        [JsonProperty(PropertyName = "code")]
        public int code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<PostRemoveResponse> response { get; set; }
    }
}
