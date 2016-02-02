using disqusNETAPI.DTO.DisqusInterface;
using disqusNETAPI.DTO.Forums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
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
           
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "disqusNETAPI.DisqusInterface.interface.json";
            var stream = assembly.GetManifestResourceStream(resourceName);

            using (StreamReader file = new StreamReader(stream))
            using (JsonReader reader = new JsonTextReader(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<RootObject>(reader);
            }
        }

    }

}
