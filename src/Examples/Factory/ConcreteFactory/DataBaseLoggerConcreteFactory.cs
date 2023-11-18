namespace Examples.Factory.Logger
{
    // Concrete class to create an instance of DataBaseLogger
    public class DataBaseLoggerConcreteFactory : AbstractLogger
    {
        public override ILogger CreateLogger()
        {
            var databaseLogger = new DataBaseLogger();
            databaseLogger.Info("In DataBaseLoggerConcreteFactory");
            return databaseLogger;
        }
    }
}
