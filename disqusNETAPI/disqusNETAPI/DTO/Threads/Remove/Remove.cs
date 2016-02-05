using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Threads.Remove
{
    public class Remove
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<RemoveResponse> Response { get; set; }
    }
}
