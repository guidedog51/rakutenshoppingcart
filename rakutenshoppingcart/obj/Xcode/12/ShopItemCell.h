// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <itemBrand/itemBrand.h>
#import <itemName/itemName.h>
#import <itemTagline/itemTagline.h>
#import <itemThumbnail/itemThumbnail.h>


@interface ShopItemCell : UITableViewCell {
	UILabel *_itemBrand;
	UILabel *_itemName;
	UILabel *_itemTagline;
	UIImageView *_itemThumbnail;
}

@property (nonatomic, retain) IBOutlet UILabel *itemBrand;

@property (nonatomic, retain) IBOutlet UILabel *itemName;

@property (nonatomic, retain) IBOutlet UILabel *itemTagline;

@property (nonatomic, retain) IBOutlet UIImageView *itemThumbnail;

@end
