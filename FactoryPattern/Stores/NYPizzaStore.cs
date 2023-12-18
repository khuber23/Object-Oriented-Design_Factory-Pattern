using FactoryPattern.Factories;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizzas CreatePizza(string type)
        {
            Pizzas pizza = null;
            NYIngredientFactory ingredientFactory = new NYIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = " NY Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "NY Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "NY Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "NY Veggie Pizza";
            }

            return pizza;
        }
    }
}