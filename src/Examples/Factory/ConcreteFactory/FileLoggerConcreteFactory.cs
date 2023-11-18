namespace Examples.Factory.Logger
{
    // Concrete class to create an instance of FileLogger
    public class FileLoggerConcreteFactory : AbstractLogger
    {
        public override ILogger CreateLogger()
        {
            var fileLogger = new FileLogger();
            fileLogger.Info("In FileLoggerConcreteFactory");
            return fileLogger;
        }
    }
}
