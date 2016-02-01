using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Thread.ListPosts
{
    public class ListPosts
    {
        [JsonProperty(PropertyName = "cursor")]
        public ListPostsCursor Cursor { get; set; }
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<ListPostsResponse> Response { get; set; }
    }
}
