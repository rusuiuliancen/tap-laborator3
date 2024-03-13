using Lab3Console.Logger;
using Lab3Console.Models;

namespace Lab3Console.Raters
{
    public class AutoPolicyRater : Rater
    {
        public AutoPolicyRater(ILogger logger)
        : base(logger)
        {

        }

        public override decimal Rate(Policy policy)
        {
            logger.Log("Rating AUTO policy...");
            logger.Log("Validating policy.");
            if (string.IsNullOrEmpty(policy.Make))
            {
                logger.Log("Auto policy must specify Make");
                return 0;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                else
                {
                    return 900m;
                }
            }

            return 0;
        }
    }
}
