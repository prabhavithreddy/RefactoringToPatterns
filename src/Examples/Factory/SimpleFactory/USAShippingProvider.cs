using System;

namespace Examples.Factory.SimpleFactory
{
    internal class USAShippingProvider : IShippingProvider
    {
        public void Ship()
        {
            Console.WriteLine("Shipped from USA");
        }
    }
}
