using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Threads.Remove
{
    public class RemoveResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
