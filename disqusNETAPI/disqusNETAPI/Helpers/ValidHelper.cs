
using disqusNETAPI.DTO.DisqusInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disqusNETAPI.Helpers
{
    public class ValidHelper
    {

        public void IsMethodValid(string topic, string action, RootObject rootObject)
        {
            var result = rootObject.topic.SingleOrDefault(s => s.name == topic).action.SingleOrDefault(s => s.name == action);
            if (result == null)
                throw new Exception();
        }

        public void ParametersNotContainApiKeys(Dictionary<string, string> parameters, RootObject rootObject, string topic, string action)
        {
            var requiredParams = rootObject.topic.SingleOrDefault(s => s.name == topic).action.SingleOrDefault(s => s.name == action).required;
            foreach (var item in parameters)
            {
                if (item.Key == "api_key" &&
                    item.Key == "api_secret" &&
                    item.Key == "access_token")
                {
                    throw new Exception();
                }
            }
        }


    }
}
