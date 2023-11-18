using Examples.Factory.SimpleFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExamplesTest.Factory.SimpleFactory
{
    [TestClass]
    public class TestLoggerFactory
    {
        [TestMethod]
        public void TestCreateShippingProvider()
        {
            var provider = ShippingProviderFactory.CreateShippingProvider("India");
            provider.Ship();
            Console.WriteLine(provider);
        }
    }
}
