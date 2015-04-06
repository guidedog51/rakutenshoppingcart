// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <btnAddToCart/btnAddToCart.h>
#import <detailDescriptionLabel/detailDescriptionLabel.h>
#import <lblPrice/lblPrice.h>
#import <lblTagline/lblTagline.h>
#import <lblTotal/lblTotal.h>
#import <qtyStepper/qtyStepper.h>
#import <toolbar/toolbar.h>
#import <txtQuantity/txtQuantity.h>
#import <wvDescription/wvDescription.h>


@interface DetailViewController : UIViewController {
	UIButton *_btnAddToCart;
	UILabel *_detailDescriptionLabel;
	UILabel *_lblPrice;
	UILabel *_lblTagline;
	UILabel *_lblTotal;
	UIStepper *_qtyStepper;
	UIToolbar *_toolbar;
	UITextField *_txtQuantity;
	UIWebView *_wvDescription;
}

@property (nonatomic, retain) IBOutlet UIButton *btnAddToCart;

@property (nonatomic, retain) IBOutlet UILabel *detailDescriptionLabel;

@property (nonatomic, retain) IBOutlet UILabel *lblPrice;

@property (nonatomic, retain) IBOutlet UILabel *lblTagline;

@property (nonatomic, retain) IBOutlet UILabel *lblTotal;

@property (nonatomic, retain) IBOutlet UIStepper *qtyStepper;

@property (nonatomic, retain) IBOutlet UIToolbar *toolbar;

@property (nonatomic, retain) IBOutlet UITextField *txtQuantity;

@property (nonatomic, retain) IBOutlet UIWebView *wvDescription;

@end
