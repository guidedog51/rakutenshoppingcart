
using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Collections.Generic;
using ObjCRuntime;


namespace rakutenshoppingcart
{
	public partial class Cart2ViewController : UIViewController
	{
		DataSource dataSource;
		IDataService mDataService;

		public Cart2ViewController () : base ("Cart2ViewController", null)
		{
			mDataService = new dataservice ();
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
			double tax = 0;
			double subtotal = 0;
			NavigationItem.LeftBarButtonItem = new UIBarButtonItem ("Continue Shopping", UIBarButtonItemStyle.Plain, (object sender, EventArgs e) => 
				this.DismissViewController (true, null)
			);

			NavigationItem.RightBarButtonItem = EditButtonItem;
			//tblCartItems.UserInteractionEnabled = false;

			EditButtonItem.Clicked += (sender, e) => {
				if (!tblCartItems.Editing) {
					EditButtonItem.Title = "Done";
					//tblCartItems.UserInteractionEnabled = true;
				}	else {
					EditButtonItem.Title = "Edit";
					ViewHelpers.FindResignFirstResponder(View);
					//tblCartItems.UserInteractionEnabled = false;
					tax = double.Parse(lblTax.Text);
					lblTotal.Text = calculateTotal(out tax, out subtotal).ToString();
					lblTax.Text = tax.ToString();
					lblSubtotal.Text = subtotal.ToString();

					mDataService.SaveCart();
				}

				tblCartItems.SetEditing(!tblCartItems.Editing, true);
			};
			// Perform any additional setup after loading the view, typically from a nib.
			this.tblCartItems.Source = dataSource = new DataSource (this, this.mDataService);

			tax = double.Parse(lblTax.Text);
			lblTotal.Text = calculateTotal(out tax, out subtotal).ToString();
			lblTax.Text = tax.ToString();
			lblSubtotal.Text = subtotal.ToString ();
		}

		protected double calculateTotal( out double tax, out double subtotal) {

			//update the totals
			double total = 0;
			subtotal = 0;

			foreach (var item in CurrentShoppingCart.Instance.CartItems) {
				subtotal += (item.quantities * Int32.Parse(item.price));
			}

			tax = subtotal * .10;	//whatever the bite is
			total = subtotal + tax + double.Parse(lblShipping.Text);
			return total;
		}

		class DataSource : UITableViewSource
		{
//			static readonly NSString CellIdentifier = new NSString ("cartCell");
			readonly Cart2ViewController controller;
			//			readonly Models.Catalog.RootObject mCatRoot;
			//			readonly Models.Item.RootObject mItemRoot;
			static List<Models.Item.Item> mCartItems;
			static IDataService mDataService = new dataservice ();
			static UITableView mCartTable = new UITableView();

			public DataSource (Cart2ViewController controller, IDataService dataService)
			{
				this.controller = controller;
				//mCatRoot = mDataService.GetCatData();
				//mItemRoot = mDataService.GetItemData();
				mCartItems = mDataService.GetCartItems();
				mCartTable = controller.tblCartItems;
				mDataService = dataService;
			}

			public IList<Models.Item.Item> ShopItems {
				get { return mCartItems; }
			}

			// Customize the number of sections in the table view.
			public override nint NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return mCartItems.Count;
			}

//			public override void DidChangeValue (string forKey)
//			{
//				base.DidChangeValue (forKey);
//			}

			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				//var cell = (CartCell)tableView.DequeueReusableCell (CellIdentifier, indexPath);

				var cell =  CartItemCell.Create();
				string altImage = "data:image/jpeg;base64,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";
				//string altImage = "http://cd8ba0b44a15c10065fd-24461f391e20b7336331d5789078af53.r23.cf1.rackcdn.com/xamarin.vanillaforums.com/userpics/455/n4TYW7U46JICD.jpg"
				Models.Item.Item cartItem = mCartItems [indexPath.Row];
				string thumbnailUrl = string.IsNullOrWhiteSpace (cartItem.thumbnailurl) ? altImage : cartItem.thumbnailurl;
				cell.ItemDescriptionText = string.IsNullOrWhiteSpace(cartItem.itemDescription) ? "Default Item Description" : cartItem.itemDescription;
				cell.ItemIdText = cartItem.itemId;
				cell.ItemQuantity = cartItem.quantities;
				cell.SetThumbnailImage (thumbnailUrl);
				cell.ItemPriceText = cartItem.price;

				//for demo we're just editing quantity
				cell.OnQuantityChanged += (sender, e) => {
					//update the cart singleton -- we'll push it when user taps done
					CurrentShoppingCart.Instance.CartItems[indexPath.Row].quantities = ((CartItemCell)sender).ItemQuantity;
				};

				cell.OnStartEdit += (sender, e) => {
					tableView.SetEditing(true, true);
					controller.EditButtonItem.Title = "Done";
				};

				return cell;
			}

			//			public async override Task<UIKit.UITableViewCell> GetCell (UIKit.UITableView tableView, NSIndexPath indexPath)
			//			{
			//				UIKit.UITableViewCell cell = await ImageHelpers.FromUrlAsync ("http://cd8ba0b44a15c10065fd-24461f391e20b7336331d5789078af53.r23.cf1.rackcdn.com/xamarin.vanillaforums.com/userpics/455/n4TYW7U46JICD.jpg");
			//				return cell;
			//			}
			//
//			public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
//			{
//				// Return false if you do not want the specified item to be editable.
//				return true;
//			}

			public override void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.CellAt (indexPath);
				cell.SetSelected (true, true);
				tableView.SelectRow (indexPath, true, new UITableViewScrollPosition());
			}

			public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
			{
				if (editingStyle == UITableViewCellEditingStyle.Delete) {
					// Delete the row from the data source.
					mCartItems.RemoveAt (indexPath.Row);
					controller.tblCartItems.DeleteRows (new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
				} else if (editingStyle == UITableViewCellEditingStyle.Insert) {
					// Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
				}

				//update singleton
				CurrentShoppingCart.Instance.CartItems = mCartItems;
			}

			/*
			// Override to support rearranging the table view.
			public override void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
			{
			}
			*/

			/*
			// Override to support conditional rearranging of the table view.
			public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
			{
				// Return false if you do not want the item to be re-orderable.
				return true;
			}
			*/
		}


	}
}

