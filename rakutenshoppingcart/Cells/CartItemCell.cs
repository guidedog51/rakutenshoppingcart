
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace rakutenshoppingcart
{
	public partial class CartItemCell : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("CartItemCell", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("CartItemCell");

		public CartItemCell (IntPtr handle) : base (handle)
		{
		}
		public string ItemDescriptionText 
		{
			get
			{
				return itemDescription.Text;
			}

			set
			{
				itemDescription.Text = value;
			}
		}

		public string ItemIdText 
		{
			get
			{
				return itemId.Text;
			}

			set
			{
				itemId.Text = value;
			}
		}

		public string ItemPriceText 
		{
			get
			{
				return lblPrice.Text;
			}

			set
			{
				lblPrice.Text = value;
				lblTotal.Text = (Double.Parse (value) * qtyStepper.Value).ToString ();
			}
		}

		public string ItemTotalText 
		{
			get
			{
				return lblTotal.Text;
			}

			set
			{
				lblTotal.Text = value;
			}
		}

		public int ItemQuantity 
		{
			get
			{
				return Int32.Parse(itemQuantity.Text);
			}

			set
			{
				itemQuantity.Text = value.ToString();
				qtyStepper.Value = (double)value;
			}
		}

		public void SetThumbnailImage(string imageUrl) {
			this.itemThumbNail.Image = ImageHelpers.FromUrl(imageUrl);
		}

//		public void EnableEditing(bool enable) {
//			qtyStepper.UserInteractionEnabled = enable;
//			itemQuantity.UserInteractionEnabled = enable;
//		}

		public static CartItemCell Create ()
		{
			CartItemCell ciCell = (CartItemCell)Nib.Instantiate (null, null) [0];

			ciCell.itemQuantity.KeyboardType = UIKeyboardType.NumberPad;

			ciCell.qtyStepper.ValueChanged += (sender, e) => {
				ciCell.ItemQuantity = (int)ciCell.qtyStepper.Value;
				ciCell.ItemTotalText = (ciCell.ItemQuantity * double.Parse(ciCell.ItemPriceText)).ToString();
				ciCell.FireQuantityChanged();
				ciCell.FireStartEdit();
			};

			ciCell.itemQuantity.EditingDidEnd += (sender, e) => {
				ciCell.ItemTotalText = (ciCell.ItemQuantity * double.Parse(ciCell.ItemPriceText)).ToString();
				ciCell.FireQuantityChanged();
			};

			ciCell.itemQuantity.EditingDidBegin += (sender, e) => {
				ciCell.FireStartEdit();
			};

//			this.EnableEditing (false);

			return ciCell;
		}

		public event EventHandler OnQuantityChanged;
		public event EventHandler OnStartEdit;

		protected void FireQuantityChanged ()
		{
			if (OnQuantityChanged != null)
				OnQuantityChanged (this, new EventArgs ());
		}

		protected void FireStartEdit ()
		{
			if (OnStartEdit != null)
				OnStartEdit (this, new EventArgs ());
		}
	}
}

