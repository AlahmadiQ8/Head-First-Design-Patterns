using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Whip : CondimentDecorator
    {

        public Whip(IBeverage beverage): base(beverage)
        {
        }

        public override string Description => Beverage.Description + ", Whipped Cream";
        public override double Cost()
        {
            return Beverage.Cost() + 0.4;
        }
    }
}
