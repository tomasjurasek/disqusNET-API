﻿using disqusNETAPI.Enums;
using disqusNETAPI.Exceptions;
using disqusNETAPI.Helpers;
using Newtonsoft.Json.Linq;
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

        public readonly string  ApiUrl = @"https://disqus.com/api/3.0";


        public DisqusApiBase()
        {
        }

        public HttpResponseMessage SendRequest(string url, Method method)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage result = null;

                Task.Run(async () =>
                {
                    try
                    {
                        if(method == Method.POST)
                        {
                            result = await client.PostAsync(url, null);
                        }
                        else
                        {
                            result = await client.GetAsync(url);
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        //handle it!
                    }
                }).Wait();

                if(!result.IsSuccessStatusCode)
                {
                    Task.Run(async () =>
                    {
                        string rawResponse = await result.Content.ReadAsStringAsync();
                   

                    try
                    {
                        JObject json = JObject.Parse(rawResponse);

                        throw new DisqusExceptionRequest((string)json["response"], (int)json["code"]);
                    }
                    catch (Exception ex)
                    {
                        throw new DisqusExceptionRequest("Error " + ex.Message + "; " + result.Content.ReadAsStringAsync(), 99);
                    }
                    }).Wait();
                }

                return result;

            }
        }



    }
}
