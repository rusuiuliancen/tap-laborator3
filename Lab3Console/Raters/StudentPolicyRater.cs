using Lab3Console.Logger;
using Lab3Console.Models;

namespace Lab3Console.Raters
{
    public class StudentPolicyRater : Rater
    {
        public StudentPolicyRater(ILogger logger) : base(logger)
        {
        }

        public override decimal Rate(Policy policy)
        {
            return 202;
        }
    }
}
