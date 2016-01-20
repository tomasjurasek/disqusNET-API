using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Helpers
{
    public class UrlHelper
    {
        public string GetUrlForRequst(string domain, Dictionary<string, string> parameters)
        {
            string url = domain;
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
