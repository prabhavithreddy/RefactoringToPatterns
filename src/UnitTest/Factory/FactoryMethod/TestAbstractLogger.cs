using Examples.Factory;
using Examples.Factory.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesTest.Factory.FactoryMethod
{
    [TestClass]
    public class TestLoggerFactory
    {
        [TestMethod]
        public void TestCreateLogger()
        {
            AbstractLogger logger = new ConsoleLoggerConcreteFactory();
            logger.GetLogger().Info("Test Info");
        }
    }
}
