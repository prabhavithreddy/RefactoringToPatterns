using System;

namespace Examples.Factory.Logger
{
    // Concrete class to log messages to File
    public class FileLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine("Error Logged to File: " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine("Info Logged to File: " + message);
        }
    }
}
