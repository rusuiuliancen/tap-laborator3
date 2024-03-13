using Lab3Console.Models;

namespace Lab3Console.PolicySerializer
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromJsonString(string policyJson);
    }
}
