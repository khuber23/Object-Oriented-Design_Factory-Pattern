using FactoryPattern.Factories;
using System;

namespace FactoryPattern
{
    public class VeggiePizza: Pizzas
    {
        private IPizzaIngredientFactory ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing: " + this.Name);
            this.Dough = this.ingredientFactory.CreateDough();
            this.Sauce = this.ingredientFactory.CreateSauce();
            this.Cheese = this.ingredientFactory.CreateCheese();
            this.Veggies = this.ingredientFactory.CreateVeggies();
        }
    }
}