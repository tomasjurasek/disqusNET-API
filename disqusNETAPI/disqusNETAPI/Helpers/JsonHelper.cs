using disqusNETAPI.DTO.Forum;
using disqusNETAPI.JsonInterface;
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

        
        public void IsMethod(string topic, string action)
        {
            var m = JsonDeserializeInterface();
            var r = m.topic.SingleOrDefault(s => s.name == topic).action.SingleOrDefault(s => s.name == action);
            if (r == null)
                throw new Exception();

        }

        private RootObject JsonDeserializeInterface()
        {
            using (StreamReader file = File.OpenText(@"C:\Prace\Moje\DisqusNetApi\disqusNETAPI\disqusNETAPI\JsonInterface\interface.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<RootObject>(reader);
            }
        }

    }

}
