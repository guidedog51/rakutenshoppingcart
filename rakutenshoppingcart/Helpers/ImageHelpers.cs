using System;
using UIKit;
using Foundation;
using System.Threading.Tasks;
using System.Net.Http;

namespace rakutenshoppingcart
{
	public static class ImageHelpers
	{
		public static UIImage FromUrl (string uri)
		{
			//uri = "http://cd8ba0b44a15c10065fd-24461f391e20b7336331d5789078af53.r23.cf1.rackcdn.com/xamarin.vanillaforums.com/userpics/455/n4TYW7U46JICD.jpg";
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl( url))
				if (data != null) {
					return UIImage.LoadFromData (data);
				} else {
					return null;
				}	
		}

		public static async Task<UIKit.UIImage> FromUrlAsync (string imageUrl)
		{
			var httpClient = new HttpClient();

			Task<byte[]> contentsTask = httpClient.GetByteArrayAsync (imageUrl);

			// await! control returns to the caller and the task continues to run on another thread
			var contents = await contentsTask;

			// load from bytes
			return UIKit.UIImage.LoadFromData (NSData.FromArray (contents));
		}
	}
}

