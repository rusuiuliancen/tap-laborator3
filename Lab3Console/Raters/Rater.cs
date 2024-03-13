using Lab3Console.Logger;
using Lab3Console.Models;

namespace Lab3Console.Raters
{
    public abstract class Rater
    {
        protected ILogger logger;

        public Rater(ILogger logger)
        {
            this.logger = logger;
        }
        public abstract decimal Rate(Policy policy);
    }
}
