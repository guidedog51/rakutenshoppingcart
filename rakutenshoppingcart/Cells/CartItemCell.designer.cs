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
	[Register ("CartItemCell")]
	partial class CartItemCell
	{
		[Outlet]
		UIKit.UILabel itemDescription { get; set; }

		[Outlet]
		UIKit.UILabel itemId { get; set; }

		[Outlet]
		UIKit.UITextField itemQuantity { get; set; }

		[Outlet]
		UIKit.UIImageView itemThumbNail { get; set; }

		[Outlet]
		UIKit.UILabel lblPrice { get; set; }

		[Outlet]
		UIKit.UILabel lblTotal { get; set; }

		[Outlet]
		UIKit.UIStepper qtyStepper { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (itemDescription != null) {
				itemDescription.Dispose ();
				itemDescription = null;
			}

			if (itemId != null) {
				itemId.Dispose ();
				itemId = null;
			}

			if (itemQuantity != null) {
				itemQuantity.Dispose ();
				itemQuantity = null;
			}

			if (itemThumbNail != null) {
				itemThumbNail.Dispose ();
				itemThumbNail = null;
			}

			if (qtyStepper != null) {
				qtyStepper.Dispose ();
				qtyStepper = null;
			}

			if (lblPrice != null) {
				lblPrice.Dispose ();
				lblPrice = null;
			}

			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
