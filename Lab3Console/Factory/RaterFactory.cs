using Lab3Console.Logger;
using Lab3Console.Models;
using Lab3Console.Raters;

namespace Lab3Console.Factory
{
    public class RaterFactory : IRaterFactory
    {
        public ILogger _logger;

        public RaterFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Rater Create(Policy policy)
        {
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(_logger);

                case PolicyType.Land:
                    return new LandPolicyRater(_logger);

                case PolicyType.Student:
                    return new StudentPolicyRater(_logger);

                default:
                    return new UnknownPolicyRater(_logger);
            }
        }
    }
}
