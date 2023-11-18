namespace Examples.Factory.Logger
{
    public interface ILogger
    {
        // Method for logging Information
        void Info(string message);
        // Method for logging Error
        void Error(string message);
    }
}
