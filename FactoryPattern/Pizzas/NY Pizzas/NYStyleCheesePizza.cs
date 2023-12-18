using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYStyleCheesePizza : CheesePizza
    {
        public NYStyleCheesePizza()
        {
            this.Name = "New York Style Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            this.toppings.Add("Grated Reggiano Cheese");
        }
    }
}
