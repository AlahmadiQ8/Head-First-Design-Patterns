namespace DecoratorPattern.Beverages
{
    class Espresso : IBeverage
    {
        public string Description => "Espresso";

        public double Cost()
        {
            return 2.0;
        }
    }
}
