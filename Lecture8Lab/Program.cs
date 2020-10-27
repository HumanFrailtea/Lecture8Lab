using System;

namespace Lecture8Lab
{
	using System;

	public class PizzaTest
	{
		public static void Main(string[] args)
		{
			Pizza p1 = new Pizza("large", 1, 1, 2);
			Pizza p2 = new Pizza("small", 2, 1, 1);
			Pizza p3 = new Pizza("medium", 1, 2, 1);

			Console.WriteLine(p1.Description);
			Console.WriteLine(p2.Description);
			Console.WriteLine(p3.Description);
		}
	}

	// Pizza.java
	public class Pizza
	{
		private string pizzaSize;
		private int cheeseCount;
		private int pepperoniCount;
		private int hamCount;

		public Pizza()
		{
			this.pizzaSize = "";
			this.cheeseCount = 0;
			this.pepperoniCount = 0;
			this.hamCount = 0;
		}

		public Pizza(string pizzaSize, int cheeseCount, int pepperoniCount, int hamCount)
		{
			this.pizzaSize = pizzaSize;
			this.cheeseCount = cheeseCount;
			this.pepperoniCount = pepperoniCount;
			this.hamCount = hamCount;
		}

		public virtual string PizzaSize
		{
			get
			{
				return pizzaSize;
			}
			set
			{
				this.pizzaSize = value;
			}
		}


		public virtual int NumCheeseToppings
		{
			get
			{
				return cheeseCount;
			}
			set
			{
				this.cheeseCount = value;
			}
		}


		public virtual int NumPepperoniToppings
		{
			get
			{
				return pepperoniCount;
			}
			set
			{
				this.pepperoniCount = value;
			}
		}


		public virtual int NumHmaToppings
		{
			get
			{
				return hamCount;
			}
			set
			{
				this.hamCount = value;
			}
		}


		public virtual double calcCost()
		{
			if (pizzaSize.Equals("small", StringComparison.OrdinalIgnoreCase))
			{
				return 10 + (cheeseCount + pepperoniCount + hamCount) * 2;
			}
			else if (pizzaSize.Equals("medium", StringComparison.OrdinalIgnoreCase))
			{
				return 12 + (cheeseCount + pepperoniCount + hamCount) * 2;
			}
			else if (pizzaSize.Equals("large", StringComparison.OrdinalIgnoreCase))
			{
				return 14 + (cheeseCount + pepperoniCount + hamCount) * 2;
			}
			else
			{
				return 0.0;
			}
		}

		public virtual string Description
		{
			get
			{
				return "Pizza size: " + pizzaSize + "\n Cheese toppings: " + cheeseCount + "\n Pepperoni toppings: " + pepperoniCount + "\n Ham toppings: " + hamCount + "\n Pizza cost: $" + calcCost() + "\n";
			}
		}
	}
}


