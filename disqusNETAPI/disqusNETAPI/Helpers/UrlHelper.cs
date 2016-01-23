using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Helpers
{
    public class UrlHelper
    {
        public  string CreateUrl(string domain, string topic, string action, Dictionary<string, string> parameters)
        {
            string url = string.Format("{0}/{1}/{2}.json", domain, topic, action);
            int i = 0;
            foreach (var item in parameters)
            {
                if (i == 0)
                {
                    url += string.Format("?{0}={1}", item.Key, item.Value);
                    i++;
                }
                else
                {
                    url += string.Format("&{0}={1}", item.Key, item.Value);
                }

            }
            return url;
        }
    }
}
