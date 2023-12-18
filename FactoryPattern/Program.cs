using FactoryPattern.Beverage;
using System;

namespace FactoryPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
			// Factory Pattern
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizzas pizza1 = pizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza1.Name}. \n");

			// Decorator Pattern
			IPizza pizza = new Pizza(pizza1);
			IPizza cheeseDecorator = new CheeseDecorator(pizza);
			IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
			IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
			Console.WriteLine(onionDecorator.GetPizzaType());
			Console.WriteLine("");

			// Factory Pattern
			PizzaStore pizzaStore2 = new ChicagoPizzaStore();
            Pizzas pizza2 = pizzaStore2.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza2.Name}. \n");

			// Decorator Pattern
			IPizza pizza3 = new Pizza(pizza2);
			IPizza onionDecorator2 = new OnionDecorator(pizza3);
			Console.WriteLine(onionDecorator2.GetPizzaType());
			Console.WriteLine("");

			// Template Pattern
			Coffee coffee = new Coffee();
			Console.WriteLine("Preparing Coffee....");
			coffee.PrepareRecipe();

			Console.Read();
        }

		// Decorator Pattern below

		// Base Interface
		interface IPizza
		{
			string GetPizzaType();
		}

		// Concrete Implementation
		class Pizza : IPizza
		{
			public Pizza(Pizzas p) { }
			public string GetPizzaType()
			{
				return "this is a normal pizza.";
			}
		}

		// base Decorator
		class PizzaDecorator : IPizza
		{
			private IPizza _pizza;

			public PizzaDecorator(IPizza pizza)
			{
				_pizza = pizza;
			}
			public virtual string GetPizzaType()
			{
				return _pizza.GetPizzaType();
			}
		}

		// Concrete Decorators
		class CheeseDecorator : PizzaDecorator
		{
			public CheeseDecorator(IPizza pizza) : base(pizza)
			{

			}

			public override string GetPizzaType()
			{
				string _type = base.GetPizzaType();
				_type += "\r\n with extra cheese";
				return _type;
			}
		}

		class TomatoDecorator : PizzaDecorator
		{
			public TomatoDecorator(IPizza pizza) : base(pizza)
			{

			}

			public override string GetPizzaType()
			{
				string _type = base.GetPizzaType();
				_type += "\r\n with extra tomatoes!";
				return _type;
			}
		}

		class OnionDecorator : PizzaDecorator
		{
			public OnionDecorator(IPizza pizza) : base(pizza)
			{

			}

			public override string GetPizzaType()
			{
				string _type = base.GetPizzaType();
				_type += "\r\n with extra onions.";
				return _type;
			}
		}
	}
}