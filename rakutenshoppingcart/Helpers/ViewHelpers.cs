using System;
using UIKit;

namespace rakutenshoppingcart
{
	public static class ViewHelpers
	{
		public static UINavigationController CreateNavigationControllerToPresent (UIViewController viewController)
		{
			var navController = new UINavigationController (viewController);
			navController.NavigationBar.Translucent = false;

			return navController;
		}

		public static UIView FindFirstResponder(UIView view)
		{
			if (view.IsFirstResponder)
				return view;

			foreach (UIView subView in view.Subviews) 
			{
				UIView firstResponderView = FindFirstResponder(subView);
				if (firstResponderView != null)
					return firstResponderView;
			}

			return null;
		}

		public static bool FindResignFirstResponder(UIView view)
		{
			UIView firstResponder = FindFirstResponder(view);
			if (firstResponder != null)
			{
				firstResponder.ResignFirstResponder();
				return true;
			}

			return false;
		}

	}
}

