using System;

namespace Examples.Factory.SimpleFactory
{
    internal class IndiaShippingProvider : IShippingProvider
    {
        public void Ship()
        {
            Console.WriteLine("Shipped from India");
        }
    }
}
