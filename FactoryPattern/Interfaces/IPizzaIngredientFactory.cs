using System.Collections.Generic;

namespace FactoryPattern.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IEnumerable<IVeggie> CreateVeggies();
        IClams CreateClams();
    }
}