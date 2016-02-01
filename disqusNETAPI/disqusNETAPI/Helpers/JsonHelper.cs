using disqusNETAPI.DTO.DisqusInterface;
using disqusNETAPI.DTO.Forums;
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
    public class JsonHelper
    {

        public T SerializeResponse<T>(HttpResponseMessage response)
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


        public RootObject JsonDeserializeInterface()
        {
            var appDomain = System.AppDomain.CurrentDomain;
            var basePath = appDomain.RelativeSearchPath ?? appDomain.BaseDirectory;
            var path = Path.Combine(basePath, "DisqusInterface", "interface.json");

            using (StreamReader file = File.OpenText(path))
            using (JsonReader reader = new JsonTextReader(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<RootObject>(reader);
            }
        }

    }

}
