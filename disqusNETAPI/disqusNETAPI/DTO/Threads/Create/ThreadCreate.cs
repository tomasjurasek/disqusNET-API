using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.Create
{
    public class ThreadCreate
    {
        [JsonProperty(PropertyName = "code")]
        public int code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public ThreadCreateResponse response { get; set; }
    }
}
