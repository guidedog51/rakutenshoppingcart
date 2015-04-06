using System;
using System.IO;
using System.Reflection;
using rakutenshoppingcart.Models.Config;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace rakutenshoppingcart
{
	public class dataservice : IDataService
	{
		Assembly mAssembly;
		public dataservice ()
		{
			mAssembly = typeof(dataservice).GetTypeInfo().Assembly;
		}

		public List<Models.Catalog.ShopItem> GetShopItems() {

			Models.Catalog.RootObject ro = GetCatData ();

			var shopitems = ro.resources.Select(r => r.response)
				.Select(si => si.shopItem)
				.Where(sii => sii != null)
				.Distinct()
				.ToList<Models.Catalog.ShopItem>();

			return shopitems;
		}

		public List<Models.Item.Item> GetCartItems() {

			//for demo -- if singleton is null load the default json
			if (CurrentShoppingCart.Instance.CartItems != null)
				return CurrentShoppingCart.Instance.CartItems;

			//try the persisted json next
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string filePath = Path.Combine(path, "item_data.json");
			if (File.Exists (filePath)) {
				using (var stream = File.Open (filePath, FileMode.Open, FileAccess.Read)) {
					using (var reader = new StreamReader(stream)) {
						var resStr = reader.ReadToEnd();
						var item = JsonConvert.DeserializeObject<List<Models.Item.Item>> (resStr);
						return item;
					}
				}
			}

			//otherwise load the default
			Models.Item.RootObject ro = GetItemData ();

			var cartItems = ro.shopCarts.SelectMany (sc => sc.items)
				.Distinct ()
				.ToList<Models.Item.Item>();

			return cartItems;
		}

		public Models.Catalog.RootObject GetCatData() {

			Stream stream = mAssembly.GetManifestResourceStream("rakutenshoppingcart.Services.data.cat_data.json");
			using (var reader = new StreamReader(stream)) {
				var resStr = reader.ReadToEnd();
				var cat = JsonConvert.DeserializeObject<Models.Catalog.RootObject> (resStr);

				return cat;
			}
		}

		public Models.Item.RootObject GetItemData() {

			Stream stream = mAssembly.GetManifestResourceStream("rakutenshoppingcart.Services.data.item_data.json");
			using (var reader = new StreamReader(stream)) {
				var resStr = reader.ReadToEnd();
				var item = JsonConvert.DeserializeObject<Models.Item.RootObject> (resStr);
				return item;
			}
		}

		//we'd need a cart service...
		public void SaveCart() {
			//for demo we'll just persist shopping cart to file system
			//we'll assume we've got a singleton to save
			if (CurrentShoppingCart.Instance.CartItems == null)
				return;

			string json = JsonConvert.SerializeObject(CurrentShoppingCart.Instance.CartItems);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string filePath = Path.Combine(path, "item_data.json");
			using (var file = File.Open(filePath, FileMode.Create, FileAccess.Write))
			using (var strm = new StreamWriter(file))
			{
				strm.Write(json);
			}
		}
	}
}

