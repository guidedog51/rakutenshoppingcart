﻿
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace rakutenshoppingcart
{
	[Register ("CartViewController")]
	public partial class CartViewController : UIViewController
	{
		public CartViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			NavigationItem.RightBarButtonItem = new UIBarButtonItem (UIBarButtonSystemItem.Cancel, (object sender, EventArgs e) => 
				this.DismissViewController (true, null)
			);

		}
	}
}

