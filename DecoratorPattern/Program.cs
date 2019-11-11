using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            IBeverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            IBeverage beverage3 = new DarkRoast();
            beverage3 = new Milk(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.Description + " $" + beverage3.Cost());

        }
    }
}
