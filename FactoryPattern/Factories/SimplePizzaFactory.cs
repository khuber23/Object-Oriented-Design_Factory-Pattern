using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
                pizza.Name = "Cheese Pizza";
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
                pizza.Name = "Pepperoni Pizza";
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
                pizza.Name = "Clam Pizza";
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
                pizza.Name = "Veggie Pizza";
            }

            return pizza;
        }
    }
}
