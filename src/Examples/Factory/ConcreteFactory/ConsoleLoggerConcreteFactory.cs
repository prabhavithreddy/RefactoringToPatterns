namespace Examples.Factory.Logger
{
    // Concrete class to create an instance of ConsoleLogger
    public class ConsoleLoggerConcreteFactory : AbstractLogger
    {
        public override ILogger CreateLogger()
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.Info("In ConsoleLoggerConcreteFactory");
            return consoleLogger;
        }
    }
}
