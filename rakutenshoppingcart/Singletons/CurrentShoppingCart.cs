using System;
using System.Collections.Generic;

namespace rakutenshoppingcart
{
	public class CurrentShoppingCart
	{
		public static CurrentShoppingCart instance;
		public static CurrentShoppingCart Instance
		{
			get
			{
				if (instance == null)
					instance = new CurrentShoppingCart();

				return instance;
			}
		}

		public List<Models.Item.Item> CartItems
		{
			get;
			set;
		}
	}
}

