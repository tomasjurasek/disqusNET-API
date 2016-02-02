using disqusNETAPI.DTO.Thread.ListPosts;
using disqusNETAPI.Enums;
using disqusNETAPI.Helpers;
using disqusNETAPI.Services.Base;
using disqusNETAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;

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
            ValidParamsAndMethod(topic, action, parameters);

            var url = urlHelper.CreateUrl(ApiUrl, topic, action, parameters, ApiKey, SecretApiKey, AccessToken);
            var response = SendRequest(url, method);
            var result = json.SerializeResponse<T>(response);

            //its need refactoring, create class for it
            var checkType = Activator.CreateInstance<T>();
            if (checkType is ListPosts)
            {
                var listPosts = (ListPosts)Convert.ChangeType(result, typeof(ListPosts));
                listPosts.Response.ForEach(i => i.Children = listPosts.Response.Where(ch => ch.Parent == i.Id).ToList());
                return (T)(object)listPosts;
            }

            return (T)result;
        }


        public HttpResponseMessage Disqus(string topic, string action, Method method, Dictionary<string, string> parameters)
        {
            ValidParamsAndMethod(topic, action, parameters);
            var url = urlHelper.CreateUrl(ApiUrl, topic, action, parameters, ApiKey, SecretApiKey, AccessToken);
            var response = SendRequest(url, method);

            return response;
        }


        private void ValidParamsAndMethod(string topic, string action, Dictionary<string, string> parameters)
        {
            var rootObject = json.JsonDeserializeInterface();
            validHelper.IsMethodValid(topic, action, rootObject);
            validHelper.ParametersNotContainApiKeys(parameters, rootObject, topic, action);
        }


    }
}
