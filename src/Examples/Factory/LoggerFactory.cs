using Examples.Factory.Logger;
using System;

namespace Examples.Factory
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(string type)
        {

            if (type == null)
            {
                return new ConsoleLogger();
            }
            type = type.ToLower();
            if (type == "console")
            {
                return new ConsoleLogger();
            }
            else if (type == "file")
            {
                return new FileLogger();
            }
            else if (type == "database")
            {
                return new DataBaseLogger();
            }
            else
            {
                throw new Exception("type is not supported");
            }
        }
    }
}
