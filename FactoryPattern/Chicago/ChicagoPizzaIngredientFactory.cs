using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Json;
using FactoryPattern.Interfaces;
using FactoryPattern.Toppings;

namespace FactoryPattern.Chicago
{
    public class ChicagoPizzaIngredientFactory: IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IEnumerable<IVeggie> CreateVeggies()
        {
            var veggies = new List<IVeggie> {new Spinach(), new Eggplant(), new SlicedPepperoni(), new BlackOlives()};
            return veggies;
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}