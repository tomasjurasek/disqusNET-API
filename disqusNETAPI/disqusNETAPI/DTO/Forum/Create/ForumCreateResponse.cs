using Newtonsoft.Json;

namespace disqusNETAPI.DTO.Forum.Create
{
    public class ForumCreateResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "founder")]
        public string Founder { get; set; }

        [JsonProperty(PropertyName = "favicon")]
        public ForumCreateResponseFavicon Favicon { get; set; } 
    }
}