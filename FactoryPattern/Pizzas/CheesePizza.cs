using FactoryPattern.Factories;
using System;

namespace FactoryPattern
{
    public class CheesePizza: Pizzas
    {
        private IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing: " + this.Name);
            this.Dough = this.ingredientFactory.CreateDough();
            this.Sauce = this.ingredientFactory.CreateSauce();
            this.Cheese = this.ingredientFactory.CreateCheese();
        }
    }
}