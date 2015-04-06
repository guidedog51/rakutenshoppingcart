// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace rakutenshoppingcart
{
	[Register ("ShopItemCell2")]
	partial class ShopItemCell2
	{
		[Outlet]
		UIKit.UILabel itemBrand { get; set; }

		[Outlet]
		UIKit.UIImageView itemImage { get; set; }

		[Outlet]
		UIKit.UILabel itemName { get; set; }

		[Outlet]
		UIKit.UILabel itemTagline { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (itemImage != null) {
				itemImage.Dispose ();
				itemImage = null;
			}

			if (itemBrand != null) {
				itemBrand.Dispose ();
				itemBrand = null;
			}

			if (itemTagline != null) {
				itemTagline.Dispose ();
				itemTagline = null;
			}

			if (itemName != null) {
				itemName.Dispose ();
				itemName = null;
			}
		}
	}
}
