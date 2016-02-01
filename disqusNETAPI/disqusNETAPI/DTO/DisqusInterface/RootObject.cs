using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.DisqusInterface
{
    public class RootObject
    {
        [JsonProperty(PropertyName = "topic")]
        public List<Topic> Topic { get; set; }
    }
}
