using Examples.Factory;
using Examples.Factory.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamplesTest.Factory
{
    [TestClass]
    public class TestLoggerFactory
    {
        [TestMethod]
        public void TestCreateShippingProvider()
        {
            ILogger logger = LoggerFactory.CreateLogger("File");
            logger.Info("Test Info");
        }
    }
}
