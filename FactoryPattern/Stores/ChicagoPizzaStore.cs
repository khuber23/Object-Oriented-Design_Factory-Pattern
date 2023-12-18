using FactoryPattern.Factories;

namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizzas CreatePizza(string type)
        {
            Pizzas pizza = null;
            ChicagoIngredientFactory ingredientFactory = new ChicagoIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "Chicago Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Veggie Pizza";
            }

            return pizza;
        }
    }
}