using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.JsonInterface
{
    public class Action
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }
        [JsonProperty(PropertyName = "required")]
        public List<string> required { get; set; }
        [JsonProperty(PropertyName = "method")]
        public string method { get; set; }
        [JsonProperty(PropertyName = "formats")]
        public List<string> formats { get; set; }
    }
}
