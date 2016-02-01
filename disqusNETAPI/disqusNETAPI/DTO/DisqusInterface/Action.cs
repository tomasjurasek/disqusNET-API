using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.DisqusInterface
{
    public class Action
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "required")]
        public List<string> Required { get; set; }
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }
        [JsonProperty(PropertyName = "formats")]
        public List<string> Formats { get; set; }
    }
}
