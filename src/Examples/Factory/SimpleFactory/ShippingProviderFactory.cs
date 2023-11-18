namespace Examples.Factory.SimpleFactory
{
    public class ShippingProviderFactory
    {
        public static IShippingProvider CreateShippingProvider(string country)
        {
            if (country.ToLower() == "india")
            {
                return new IndiaShippingProvider();
            }
            else
            {
                return new USAShippingProvider();
            }
        }
    }
}
