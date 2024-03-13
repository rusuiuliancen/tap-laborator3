using Lab3Console.Factory;
using Lab3Console.Logger;

namespace Lab3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting");

            var loggerInstance = new SecondLogger();
            var engine = new RatingEngine(
                loggerInstance,
                new FileSource.FileSource(),
                new PolicySerializer.PolicySerializer(),
                new RaterFactory(loggerInstance));
            
            engine.Rate();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("no rating.");
            }
        }
    }
}
