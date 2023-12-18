
namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizzas OrderPizza(string type)
        {
            Pizzas pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizzas CreatePizza(string type);
    }
}