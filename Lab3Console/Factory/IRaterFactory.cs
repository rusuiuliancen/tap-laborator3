using Lab3Console.Models;
using Lab3Console.Raters;

namespace Lab3Console.Factory
{
    public interface IRaterFactory
    {
        Rater Create(Policy policy);
    }
}
