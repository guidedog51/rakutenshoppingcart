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
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		UIKit.UIButton btnAddToCart { get; set; }

		[Outlet]
		UIKit.UILabel detailDescriptionLabel { get; set; }

		[Outlet]
		UIKit.UILabel lblPrice { get; set; }

		[Outlet]
		UIKit.UILabel lblTagline { get; set; }

		[Outlet]
		UIKit.UILabel lblTotal { get; set; }

		[Outlet]
		UIKit.UIStepper qtyStepper { get; set; }

		[Outlet]
		UIKit.UIToolbar toolbar { get; set; }

		[Outlet]
		UIKit.UITextField txtQuantity { get; set; }

		[Outlet]
		UIKit.UIWebView wvDescription { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnAddToCart != null) {
				btnAddToCart.Dispose ();
				btnAddToCart = null;
			}

			if (detailDescriptionLabel != null) {
				detailDescriptionLabel.Dispose ();
				detailDescriptionLabel = null;
			}

			if (toolbar != null) {
				toolbar.Dispose ();
				toolbar = null;
			}

			if (wvDescription != null) {
				wvDescription.Dispose ();
				wvDescription = null;
			}

			if (lblPrice != null) {
				lblPrice.Dispose ();
				lblPrice = null;
			}

			if (lblTagline != null) {
				lblTagline.Dispose ();
				lblTagline = null;
			}

			if (txtQuantity != null) {
				txtQuantity.Dispose ();
				txtQuantity = null;
			}

			if (qtyStepper != null) {
				qtyStepper.Dispose ();
				qtyStepper = null;
			}

			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
