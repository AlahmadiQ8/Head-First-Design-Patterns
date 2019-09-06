using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public void SetFlyBehavior(IFlyBehavior f)
        {
            FlyBehavior = f;
        }
    }
}