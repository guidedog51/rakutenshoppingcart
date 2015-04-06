
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace rakutenshoppingcart
{
	public partial class ShopItemCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ShopItemCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ShopItemCell");

		public ShopItemCell (IntPtr handle) : base (handle)
		{
		}

		public void SetThumbnailImage(string imageUrl) {
			itemThumbnail.Image = ImageHelpers.FromUrl(imageUrl);

			//this.itemThumbnail.Image
		}



		public static ShopItemCell Create ()
		{
			return (ShopItemCell)Nib.Instantiate (null, null) [0];
		}
	}
}

