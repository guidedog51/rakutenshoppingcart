// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <btnUpdat/btnUpdat.h>
#import <cellItem/cellItem.h>
#import <lblShipping/lblShipping.h>
#import <lblSubtotal/lblSubtotal.h>
#import <lblTax/lblTax.h>
#import <lblTotal/lblTotal.h>
#import <tblCartItems/tblCartItems.h>


@interface Cart2ViewController : UIViewController {
	UIButton *_btnUpdat;
	UITableViewCell *_cellItem;
	UILabel *_lblShipping;
	UILabel *_lblSubtotal;
	UILabel *_lblTax;
	UILabel *_lblTotal;
	UITableView *_tblCartItems;
}

@property (nonatomic, retain) IBOutlet UIButton *btnUpdat;

@property (nonatomic, retain) IBOutlet UITableViewCell *cellItem;

@property (nonatomic, retain) IBOutlet UILabel *lblShipping;

@property (nonatomic, retain) IBOutlet UILabel *lblSubtotal;

@property (nonatomic, retain) IBOutlet UILabel *lblTax;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UITableView *tblCartItems;

@end
