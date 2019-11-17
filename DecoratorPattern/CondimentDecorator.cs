namespace DecoratorPattern
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected readonly IBeverage Beverage;

        protected CondimentDecorator(IBeverage beverage)
        {
            Beverage = beverage;
        }

        public abstract string Description { get; }
        public abstract double Cost();
    }
}