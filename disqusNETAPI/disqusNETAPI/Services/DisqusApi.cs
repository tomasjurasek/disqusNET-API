using disqusNETAPI.Helpers;
using disqusNETAPI.JsonInterface;
using disqusNETAPI.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Services
{
    public class DisqusApi : DisqusApiBase
    {
        private Json json;

        public DisqusApi()
        {
            json = new Json();
        }
        public T Disqus<T>(string topic, string action, Dictionary<string, string> parameters)
        {


            var m = json.IsMethod();
            var r = m.topic.SingleOrDefault(s => s.name == topic).action.Single(s => s.name == action);
            if (r == null)
                throw new Exception();



            var url = UrlHelper.GetUrlForRequst(ApiUrl, topic, action, parameters);
            var response = SendRequestPost(url);
            var result = Json.JsonSerialize<T>(response);

            return(T)result;

        }

        public HttpResponseMessage Disqus(string topic, string action, Dictionary<string, string> parameters)
        {

            var m = json.IsMethod();
            var r = m.topic.SingleOrDefault(s => s.name == topic).action.Single(s => s.name == action);
            if (r == null)
                throw new Exception();



            var url = UrlHelper.GetUrlForRequst(ApiUrl, topic, action, parameters);
            var response = SendRequestPost(url);

            return response;

        }


    }
}
