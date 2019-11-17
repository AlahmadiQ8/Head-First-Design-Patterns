using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description => Beverage.Description + ", Mocha";

        public override double Cost()
        {
            return Beverage.Cost() + 0.2;
        }
    }
}
