using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Lab3Console.Models;

namespace Lab3Console.PolicySerializer
{
    public class PolicySerializer : IPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());
        }
    }
}
