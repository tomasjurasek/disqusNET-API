using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Forums.ListThreads
{
   public class ListThreads
    {

        [JsonProperty(PropertyName = "cursor")]
        public ListThreadsCursor cursor { get; set; }
        [JsonProperty(PropertyName = "code")]
        public int code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<ListThreadsResponse> response { get; set; }
    }
}
