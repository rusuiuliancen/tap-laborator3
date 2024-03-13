
using Lab3Console.Logger;

namespace Lab3Console.Logger
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
