using Lab3Console.Logger;
using Lab3Console.Models;

namespace Lab3Console.Raters
{
    public class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            return 0;
        }
    }
}
