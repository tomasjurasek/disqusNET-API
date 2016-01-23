using disqusNETAPI.Enums;
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
        private ValidHelper validHelper;

        public DisqusApi()
        {
            json = new JsonHelper();
            urlHelper = new UrlHelper();
            validHelper = new ValidHelper();
        }
        public T Disqus<T>(string topic, string action, Method method, Dictionary<string, string> parameters)
        {
            var rootObject = json.JsonDeserializeInterface();
            validHelper.IsMethodValid(topic, action, rootObject);

            var url = urlHelper.CreateUrl(ApiUrl, topic, action, parameters);
            var response = SendRequest(url, method);
            var result = json.SerializeResponse<T>(response);

            return (T)result;

        }

        public HttpResponseMessage Disqus(string topic, string action,Method method, Dictionary<string, string> parameters)
        {
            var rootObject = json.JsonDeserializeInterface();
            validHelper.IsMethodValid(topic, action, rootObject);

            var url = urlHelper.CreateUrl(ApiUrl, topic, action, parameters);
            var response = SendRequest(url, method);

            return response;

        }


    }
}
