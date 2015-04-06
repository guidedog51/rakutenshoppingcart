using System;
using System.Collections.Generic;

namespace rakutenshoppingcart
{
	public class CurrentShopItem
	{
		public static CurrentShopItem instance;
		public static CurrentShopItem Instance
		{
			get
			{
				if (instance == null)
					instance = new CurrentShopItem();

				return instance;
			}
		}

		public Models.Catalog.ShopItem ShopItem
		{
			get;
			set;
		}
	}
}

