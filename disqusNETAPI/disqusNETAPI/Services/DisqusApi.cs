
using disqusNETAPI.Enum;
using disqusNETAPI.Helpers;
using disqusNETAPI.Services.Base;
using disqusNETAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace disqusNETAPI.Services
{
    public class DisqusApi : DisqusApiBase, IDisqusApi
    {
        private JsonHelper json;
        private UrlHelper urlHelper;

        public DisqusApi()
        {
            json = new JsonHelper();
            urlHelper = new UrlHelper();
        }
        public T Disqus<T>(string topic, string action, Method method, Dictionary<string, string> parameters)
        {

            json.IsMethod(topic, action);

            var url = urlHelper.CreateUrlForRequest(ApiUrl, topic, action, parameters);
            var response = SendRequest(url, method);
            var result = json.JsonSerialize<T>(response);

            return (T)result;

        }

        public HttpResponseMessage Disqus(string topic, string action,Method method, Dictionary<string, string> parameters)
        {
            json.IsMethod(topic, action);


            var url = urlHelper.CreateUrlForRequest(ApiUrl, topic, action, parameters);
            var response = SendRequest(url,method);

            return response;

        }


    }
}
