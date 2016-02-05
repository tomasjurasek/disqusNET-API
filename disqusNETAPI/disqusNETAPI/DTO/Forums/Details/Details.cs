using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Forums.Details
{
    public class Details
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public DetailsResponse Response { get; set; }
    }
}
