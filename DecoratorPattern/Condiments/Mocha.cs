using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DecoratorPattern.Condiments
{
    class Mocha : ICondimentDecorator
    {
        private readonly IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string Description => _beverage.Description + ", Mocha";

        public double Cost()
        {
            return _beverage.Cost() + 0.2;
        }
    }
}
