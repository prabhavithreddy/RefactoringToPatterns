using Examples.Factory.Logger;

namespace Examples.Factory
{
    public abstract class AbstractLogger
    {
        public abstract ILogger CreateLogger();

        public ILogger GetLogger() { 
            return this.CreateLogger();
        }
    }
}
