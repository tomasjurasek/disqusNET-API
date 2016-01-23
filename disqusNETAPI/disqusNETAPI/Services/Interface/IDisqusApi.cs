using disqusNETAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Services.Interface
{
    public interface IDisqusApi
    {
        HttpResponseMessage Disqus(string topic, string action, Method method, Dictionary<string, string> parameters);
        T Disqus<T>(string topic, string action, Method method, Dictionary<string, string> parameters);
    }
}
