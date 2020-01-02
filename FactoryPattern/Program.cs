using System;
using FactoryPattern.Chicago;
using FactoryPattern.NewYork;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoPizzaStore = new ChicagoPizzaStore();

            nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("\n");
            
            nyPizzaStore.OrderPizza("clam");
            Console.WriteLine("\n");
            
            chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine("\n");
            
            chicagoPizzaStore.OrderPizza("clam");
        }
    }
}