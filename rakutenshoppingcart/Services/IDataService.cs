using System;
using System.Collections.Generic;

namespace rakutenshoppingcart
{
	public interface IDataService
	{
		List<Models.Catalog.ShopItem> GetShopItems ();
		List<Models.Item.Item> GetCartItems ();
		Models.Catalog.RootObject GetCatData ();
		Models.Item.RootObject GetItemData ();
		void SaveCart();
	}
}

