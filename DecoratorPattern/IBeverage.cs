namespace DecoratorPattern
{
    public interface IBeverage
    {
        string Description { get; }

        double Cost();
    }
}