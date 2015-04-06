
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace rakutenshoppingcart
{
	public partial class ShopItemCell2 : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("ShopItemCell2", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("ShopItemCell2");

		public ShopItemCell2 (IntPtr handle) : base (handle)
		{
		}

		public void SetThumbnailImage(string imageUrl) {
			this.itemImage.Image = ImageHelpers.FromUrl(imageUrl);
		}

		public string ItemBrandText 
		{
			get
			{
				return itemBrand.Text;
			}

			set
			{
				itemBrand.Text = value;
			}
		}

		public string ItemNameText
		{
			get
			{
				return itemName.Text;
			}

			set
			{
				itemName.Text = value;
			}
		}

		public string ItemTaglineText 
		{
			get
			{
				return itemTagline.Text;
			}

			set
			{
				itemTagline.Text = value;
			}
		}




		public static ShopItemCell2 Create ()
		{
			return (ShopItemCell2)Nib.Instantiate (null, null) [0];
		}
	}
}

