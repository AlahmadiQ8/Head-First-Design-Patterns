using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Milk : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Milk(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Milk";
        public double Cost()
        {
            return _beverage.Cost() + 0.3;
        }
    }
}
