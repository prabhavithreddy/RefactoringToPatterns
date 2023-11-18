using System;

namespace Examples.Factory.Logger
{
    // Concrete class to log messages to Database
    public class DataBaseLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine("Error Logged to DataBase: " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine("Info Logged to DataBase: " + message);
        }
    }
}
