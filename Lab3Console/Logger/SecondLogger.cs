﻿using Lab3Console.Logger;

namespace Lab3Console.Logger
{
    public class SecondLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(">>Logger2: " + message);
        }
    }
}
