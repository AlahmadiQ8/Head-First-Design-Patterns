namespace DecoratorPattern.Beverages
{
    class DarkRoast : IBeverage
    {
        public string Description => "Dark Roast";
        public double Cost()
        {
            return 3.00;
        }
    }
}
