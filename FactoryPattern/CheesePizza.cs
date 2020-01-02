using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern
{
    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClams();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}