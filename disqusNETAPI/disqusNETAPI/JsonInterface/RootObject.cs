using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.JsonInterface
{
    public class RootObject
    {
        [JsonProperty(PropertyName = "topic")]
        public List<Topic> topic { get; set; }
    }
}
