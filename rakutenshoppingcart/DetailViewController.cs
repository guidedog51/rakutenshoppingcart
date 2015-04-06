using System;
using System.Drawing;
using System.Collections.Generic;

using Foundation;
using UIKit;
using System.IO;

namespace rakutenshoppingcart
{
	public partial class DetailViewController : UIViewController
	{
		Models.Catalog.ShopItem detailItem;
		string htmlMarkup;

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

		public void SetDetailItem (Models.Catalog.ShopItem newDetailItem)
		{
			if (detailItem != newDetailItem) {
				detailItem = newDetailItem;
				CurrentShopItem.Instance.ShopItem = detailItem;

				// Update the view
				ConfigureView ();
			}
		}

		public void SetWebViewHtml (string newHtmlMarkup)
		{
			if (htmlMarkup != newHtmlMarkup) {
				htmlMarkup = newHtmlMarkup;

				// Update the view
				ConfigureView ();
			}
		}

		void ConfigureView ()
		{
			// Update the user interface for the detail item
			if (IsViewLoaded && detailItem != null) {	
				detailDescriptionLabel.Text = detailItem.ToString ();
				qtyStepper.Value = 1;
				qtyStepper.StepValue = 1;
				qtyStepper.MinimumValue = 1;
				txtQuantity.UserInteractionEnabled = false;
				Title = detailItem.brand;
				string price = detailItem.variants [0].defaultPricing.price;
				this.lblTotal.Text = price.ToString ();
				this.lblPrice.Text = price.ToString();
				this.txtQuantity.Text = "1";
				this.lblTagline.Text = detailItem.tagline;
				//use the provided markup for description content
				string contentDirectoryPath = Path.Combine (NSBundle.MainBundle.BundlePath, "content/");
				wvDescription.LoadHtmlString(htmlMarkup, new NSUrl(contentDirectoryPath, true));

				qtyStepper.ValueChanged += (sender, e) => {
					txtQuantity.Text = qtyStepper.Value.ToString();
					lblTotal.Text = ((int)qtyStepper.Value * Double.Parse(price)).ToString();
				};


			}
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


			UIViewController cart2 = new Cart2ViewController ();
			var nav = ViewHelpers.CreateNavigationControllerToPresent(cart2);

			//cart is modal from either master or detail view
			var cartButton = new UIBarButtonItem (UIImage.FromBundle ("cart"), UIBarButtonItemStyle.Plain, delegate {
				NavigationController.PresentViewController (nav, true, null);
			});


			NavigationItem.RightBarButtonItem = cartButton;

			this.btnAddToCart.TouchUpInside += (sender, e) => {
				Models.Catalog.ShopItem si = CurrentShopItem.Instance.ShopItem;
				Models.Item.Item newItem = new rakutenshoppingcart.Models.Item.Item();

				newItem.currency = si.variants[0].defaultPricing.currencyCode;
				newItem.itemDescription = si.name;
				newItem.itemId = si.itemId;
				newItem.itemVariantId = si.variants[0].itemVariantId;	//from UI no doubt or campaign
				newItem.merchantId = si.merchantId;
				newItem.price = si.variants[0].defaultPricing.price;   //have a look at the catalog to drill for this value -- it's Variant.DefaultPricing.Price
				newItem.quantities = Int32.Parse(txtQuantity.Text); //from UI
				newItem.thumbnailurl = si.images[0].location;

				CurrentShoppingCart.Instance.CartItems.Add(newItem);

			};

			
			// Perform any additional setup after loading the view, typically from a nib.
			ConfigureView ();
		}
	}
}

