using disqusNETAPI.DTO;
using disqusNETAPI.DTO.Forum;
using disqusNETAPI.DTO.Forum.Create;
using disqusNETAPI.Services.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Services.Forum
{
    public class DisqusForumCreate : DisqusApiBase
    {
        private readonly string ApiUrlCreateForum = @"https://disqus.com/api/3.0/forums/create.json";
        public ForumCreate CreateForum(string shortName, string name, string website)
        {
            var parameters = new Dictionary<string, string>
            {
                {"access_token", AccessToken },
                {"api_key", ApiKey },
                {"api_secret", SecretApiKey },
                {"name", name },
                {"short_name",shortName },
                {"website", website}
            };
            var url = UrlHelper.GetUrlForRequst(ApiUrlCreateForum, parameters);
            var response =  SendRequest(url);
            var result = Json.JsonSerialize<ForumCreate>(response);

            return result;
        }
    }
}
