// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <itemDescription/itemDescription.h>
#import <itemId/itemId.h>
#import <itemQuantity/itemQuantity.h>
#import <itemThumbNail/itemThumbNail.h>
#import <lblPrice/lblPrice.h>
#import <lblTotal/lblTotal.h>
#import <qtyStepper/qtyStepper.h>


@interface CartItemCell : UITableViewCell {
	UILabel *_itemDescription;
	UILabel *_itemId;
	UITextField *_itemQuantity;
	UIImageView *_itemThumbNail;
	UILabel *_lblPrice;
	UILabel *_lblTotal;
	UIStepper *_qtyStepper;
}

@property (nonatomic, retain) IBOutlet UILabel *itemDescription;

@property (nonatomic, retain) IBOutlet UILabel *itemId;

@property (nonatomic, retain) IBOutlet UITextField *itemQuantity;

@property (nonatomic, retain) IBOutlet UIImageView *itemThumbNail;

@property (nonatomic, retain) IBOutlet UILabel *lblPrice;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UIStepper *qtyStepper;

@end
