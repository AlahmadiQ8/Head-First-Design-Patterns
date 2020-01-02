using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        
        protected IDough Dough;
        protected ISauce Sauce;
        protected IEnumerable<IVeggie> Veggies;
        protected ICheese Cheese;
        protected IClams Clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}