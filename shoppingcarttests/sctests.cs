
using System;
using NUnit.Framework;
using rakutenshoppingcart;
using System.Collections.Generic;

namespace shoppingcarttests
{
	[TestFixture]
	public class sctests
	{
		[Test]
		public void CreatePersistedShoppingCart ()
		{
			//CurrentShoppingCart currentCart = CurrentShoppingCart.Instance;
			rakutenshoppingcart.Models.Item.Item scItem = new rakutenshoppingcart.Models.Item.Item ();

			scItem.itemDescription = "testItemDescription";

			//currentCart.CartItems.Add(scItem);
			List<rakutenshoppingcart.Models.Item.Item> cartList = new List<rakutenshoppingcart.Models.Item.Item> ();
			CurrentShoppingCart.Instance.CartItems = cartList;
			CurrentShoppingCart.Instance.CartItems.Add (scItem);
			Assert.True (CurrentShoppingCart.Instance.CartItems.Count == 1);	// && CurrentShoppingCart.Instance.CartItems[0].itemDescription.Equals("testDescription"));
		}

		[Test]
		public void GetPersistedShoppingCartItem ()
		{
			if (CurrentShoppingCart.Instance.CartItems == null) {
				Assert.False (true);
			} else {

				Assert.True (CurrentShoppingCart.Instance.CartItems [0].itemDescription.Equals("testItemDescription"));
			}
		}

	}
}
