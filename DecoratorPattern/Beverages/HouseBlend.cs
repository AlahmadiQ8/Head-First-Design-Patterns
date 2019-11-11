namespace DecoratorPattern.Beverages
{
    class HouseBlend : IBeverage
    {
        public string Description => "House Blend";
        public double Cost()
        {
            return 3.00;
        }
    }
}
