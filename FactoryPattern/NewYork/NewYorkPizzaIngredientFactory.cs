using System.Collections.Generic;
using System.Security.Cryptography;
using FactoryPattern.Interfaces;
using FactoryPattern.Toppings;

namespace FactoryPattern.NewYork
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IEnumerable<IVeggie> CreateVeggies()
        {
            var veggies = new List<IVeggie> {new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
            return veggies;
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}