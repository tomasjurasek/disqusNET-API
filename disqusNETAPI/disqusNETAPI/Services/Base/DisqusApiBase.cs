using disqusNETAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Services.Base
{
    public class DisqusApiBase
    {
        public readonly string SecretApiKey = ConfigurationManager.AppSettings["Disqus:AppSecret"];
        public readonly string ApiKey = ConfigurationManager.AppSettings["Disqus:AppId"];
        public  readonly string AccessToken = ConfigurationManager.AppSettings["Disqus:AccessToken"];


        public Json Json;
        public UrlHelper UrlHelper;
        public DisqusApiBase()
        {
            Json = new Json();
            UrlHelper = new UrlHelper();
        }

        public HttpResponseMessage SendRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage result = null;

                Task.Run(async () =>
                {
                    try
                    {
                        result = await client.PostAsync(url, null);
                    }
                    catch (Exception ex)
                    {
                        //handle it!
                    }
                }).Wait();

                return result;

            }
        }

        
    }
}
