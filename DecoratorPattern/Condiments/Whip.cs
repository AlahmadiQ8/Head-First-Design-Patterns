using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Whip : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Whipped Cream";
        public double Cost()
        {
            return _beverage.Cost() + 0.4;
        }
    }
}
