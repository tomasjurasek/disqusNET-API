using disqusNETAPI.DTO.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.DTO.Forums.ListMostLikedUsers
{
    public class ListMostLikedUsers
    {
        [JsonProperty(PropertyName = "cursor")]
        public ResponseCursor Cursor { get; set; }
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }
        [JsonProperty(PropertyName = "response")]
        public List<object> Response { get; set; }
    }
}
