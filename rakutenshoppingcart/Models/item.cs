using System;
using System.Collections.Generic;

namespace rakutenshoppingcart.Models.Item
{
	public class Item
	{
		public string merchantId { get; set; }
		public string itemId { get; set; }
		public string itemVariantId { get; set; }
		public string price { get; set; }
		public string currency { get; set; }
		public int quantities { get; set; }
		//extending this a bit
		public string thumbnailurl { get; set; }
		public string itemDescription { get; set; }
	}

	public class ShopCart
	{
		public string shopId { get; set; }
		public List<Item> items { get; set; }
	}

	public class RootObject
	{
		public int status { get; set; }
		public string message { get; set; }
		public string shopperId { get; set; }
		public List<ShopCart> shopCarts { get; set; }
	}
}

