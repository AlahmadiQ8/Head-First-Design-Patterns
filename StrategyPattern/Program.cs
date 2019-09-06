namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Swim();
            mallard.PerformQuack();
            mallard.PerformFly();
        }

    }
}