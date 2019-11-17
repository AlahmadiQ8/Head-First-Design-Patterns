using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Milk : CondimentDecorator
    {
        public Milk(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description => Beverage.Description + ", Milk";

        public override double Cost()
        {
            return Beverage.Cost() + 0.3;
        }
    }
}
