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
        public ListThreadsCursor Cursor { get; set; }
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<ListThreadsResponse> Response { get; set; }
    }
}
