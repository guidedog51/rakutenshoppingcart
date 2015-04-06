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
	[Register ("Cart2ViewController")]
	partial class Cart2ViewController
	{
		[Outlet]
		UIKit.UIButton btnUpdat { get; set; }

		[Outlet]
		UIKit.UITableViewCell cellItem { get; set; }

		[Outlet]
		UIKit.UILabel lblShipping { get; set; }

		[Outlet]
		UIKit.UILabel lblSubtotal { get; set; }

		[Outlet]
		UIKit.UILabel lblTax { get; set; }

		[Outlet]
		UIKit.UILabel lblTotal { get; set; }

		[Outlet]
		UIKit.UITableView tblCartItems { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnUpdat != null) {
				btnUpdat.Dispose ();
				btnUpdat = null;
			}

			if (cellItem != null) {
				cellItem.Dispose ();
				cellItem = null;
			}

			if (tblCartItems != null) {
				tblCartItems.Dispose ();
				tblCartItems = null;
			}

			if (lblSubtotal != null) {
				lblSubtotal.Dispose ();
				lblSubtotal = null;
			}

			if (lblTax != null) {
				lblTax.Dispose ();
				lblTax = null;
			}

			if (lblShipping != null) {
				lblShipping.Dispose ();
				lblShipping = null;
			}

			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
