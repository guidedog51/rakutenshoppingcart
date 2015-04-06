using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation;
using UIKit;

namespace rakutenshoppingcart
{
	public partial class MasterViewController : UITableViewController
	{
		DataSource dataSource;

		public MasterViewController (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.LocalizedString ("Shop", "Shop");

			// Custom initialization
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

			var cartButton = new UIBarButtonItem (UIImage.FromBundle ("cart"), UIBarButtonItemStyle.Plain, delegate {
				NavigationController.PresentViewController (nav, true, null);
			});

			NavigationItem.RightBarButtonItem = cartButton;

			TableView.Source = dataSource = new DataSource (this);
		}

		class DataSource : UITableViewSource
		{
			static readonly NSString CellIdentifier = new NSString ("Cell");
			readonly MasterViewController controller;
			readonly List<Models.Catalog.ShopItem> mShopItems;
			readonly List<Models.Item.Item> mCartItems;
			static IDataService mDataService = new dataservice ();

			public DataSource (MasterViewController controller)
			{
				this.controller = controller;
				mShopItems = mDataService.GetShopItems();
				mCartItems = mDataService.GetCartItems();
				CurrentShoppingCart.Instance.CartItems = mCartItems;
			}

			public IList<Models.Catalog.ShopItem> ShopItems {
				get { return mShopItems; }
			}

			// Customize the number of sections in the table view.
			public override nint NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return mShopItems.Count;
			}

			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				//var cell = (ShopItemCell)tableView.DequeueReusableCell (CellIdentifier, indexPath);
				var cell = ShopItemCell2.Create ();
//				cell.Text = mShopItems [indexPath.Row].brand;
//				cell.DetailTextLabel.Text = mShopItems [indexPath.Row].name;
//				cell.ImageView.Image = ImageHelpers.FromUrl(mShopItems[indexPath.Row].images[0].location);
				cell.Accessory = UITableViewCellAccessory.DetailButton;
				Models.Catalog.ShopItem item = mShopItems [indexPath.Row];
				cell.SetThumbnailImage(item.images[0].location);
				cell.ItemBrandText = item.brand;
				cell.ItemNameText = item.name;
				cell.ItemTaglineText = item.tagline;

				return cell;
			}

			public override bool CanEditRow (UITableView tableView, NSIndexPath indexPath)
			{
				// Return false if you do not want the specified item to be editable.
				return false;
			}

			public override void AccessoryButtonTapped (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = tableView.CellAt (indexPath);
				cell.SetSelected (true, true);
				tableView.SelectRow (indexPath, true, new UITableViewScrollPosition());
				controller.PerformSegue("showDetail", cell);
			}

			public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
			{
				if (editingStyle == UITableViewCellEditingStyle.Delete) {
					// Delete the row from the data source.
					mShopItems.RemoveAt (indexPath.Row);
					controller.TableView.DeleteRows (new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
				}
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

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "showDetail") {
				var indexPath = TableView.IndexPathForSelectedRow;
				var item = dataSource.ShopItems [indexPath.Row];

				((DetailViewController)segue.DestinationViewController).SetDetailItem (item);
				((DetailViewController)segue.DestinationViewController).SetWebViewHtml (item.descriptionHtml);
			}
		}
	}
}

