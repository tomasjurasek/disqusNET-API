using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Posts.Remove
{
    public class PostRemoveResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
    }
}
