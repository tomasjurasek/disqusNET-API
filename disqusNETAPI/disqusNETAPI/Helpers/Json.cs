using disqusNETAPI.DTO.Forum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Helpers
{
    public class Json
    {

        public T JsonSerialize<T>(HttpResponseMessage response)
        {
            object result = default(T);

            Task.Run(async () =>
            {
                using (StreamReader sr = new StreamReader(await response.Content.ReadAsStreamAsync()))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        result = serializer.Deserialize<T>(reader);
                    }
                }
            }).Wait();

            return (T)result;
        }
    }
}
