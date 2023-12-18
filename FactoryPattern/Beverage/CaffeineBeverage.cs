using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Beverage
{
	public abstract class CaffeineBeverage
	{
		public void PrepareRecipe()
		{
			this.BoilWater();
			this.Brew();
			this.PourInCup();
			if (this.CustomerWantsCondiment() is true)
			{
				this.AddCondiments();
			}
		}

		public abstract void AddCondiments();

		public void BoilWater()
		{
			Console.WriteLine("Boiling Water");
		}

		public abstract void Brew();

		public virtual bool CustomerWantsCondiment()
		{
			return true;
		}

		public void PourInCup()
		{
			Console.WriteLine($"Pouring {this.GetType().Name.ToString()} into cup.");
		}
	}
}
