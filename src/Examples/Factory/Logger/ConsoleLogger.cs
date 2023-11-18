using System;

namespace Examples.Factory.Logger
{
    // Concrete class to log messages to console
    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine("Error Logged to Console: " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine("Info Logged to Console: " + message);
        }
    }
}
