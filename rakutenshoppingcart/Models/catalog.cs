using System;
using System.Collections.Generic;

namespace rakutenshoppingcart.Models.Catalog
{

	public class Name
	{
		public string value { get; set; }
	}

	public class Country
	{
		public string code { get; set; }
		public Name name { get; set; }
	}

	public class Address
	{
		public string addressId { get; set; }
		public string name { get; set; }
		public string address1 { get; set; }
		public string city { get; set; }
		public string province { get; set; }
		public string postalCode { get; set; }
		public string countryCode { get; set; }
		public Country country { get; set; }
		public string description { get; set; }
	}

	public class ContactPhone
	{
		public string shopContactId { get; set; }
		public string name { get; set; }
		public string countryCode { get; set; }
		public string phoneNumber { get; set; }
		public string emailAddress { get; set; }
	}

	public class Rmail
	{
		public bool isActive { get; set; }
	}

	public class Services
	{
		public Rmail rmail { get; set; }
	}

	public class Contract
	{
		public string contractId { get; set; }
		public string name { get; set; }
		public string contractPlanType { get; set; }
		public string feePercent { get; set; }
		public string maxItemCount { get; set; }
		public string maxStorageDb { get; set; }
		public Services services { get; set; }
		public string liveStartTime { get; set; }
	}

	public class TimeZone
	{
		public string timeZoneId { get; set; }
		public string timeZoneSerializedValue { get; set; }
	}

	public class Name2
	{
		public string value { get; set; }
	}

	public class Status
	{
		public string statusId { get; set; }
		public string name { get; set; }
		public string accountOpenTime { get; set; }
		public string shopOpenTime { get; set; }
		public string lastModifiedTime { get; set; }
	}

	public class Shop
	{
		public string mallId { get; set; }
		public string shopUrl { get; set; }
		public string shopNumber { get; set; }
		public bool isTest { get; set; }
		public string companyRegistrationNumber { get; set; }
		public bool isInquiryAccepted { get; set; }
		public bool isPrimaryShop { get; set; }
		public string emailAddress { get; set; }
		public List<Address> addresses { get; set; }
		public List<ContactPhone> contactPhones { get; set; }
		public List<object> contactFaxs { get; set; }
		public Contract contract { get; set; }
		public string merchantId { get; set; }
		public string shopId { get; set; }
		public string countryCode { get; set; }
		public string languageCode { get; set; }
		public string currencyCode { get; set; }
		public TimeZone timeZone { get; set; }
		public Name2 name { get; set; }
		public Status status { get; set; }
	}

	public class Duration
	{
		public string liveStartTime { get; set; }
		public string liveEndTime { get; set; }
	}

	public class ShopCategory
	{
		public string shopCategoryId { get; set; }
		public string shopCategoryKey { get; set; }
		public string displayName { get; set; }
	}

	public class Image
	{
		public string location { get; set; }
		public string alt { get; set; }
	}

	public class ShippingWeight
	{
		public string unitCode { get; set; }
		public string value { get; set; }
	}

	public class DefaultPricing
	{
		public string currencyCode { get; set; }
		public string price { get; set; }
		public string originalPrice { get; set; }
	}

	public class Quantity
	{
		public int value { get; set; }
		public bool unlimited { get; set; }
	}

	public class ShippingDimension
	{
		public string unitCode { get; set; }
		public string width { get; set; }
		public string height { get; set; }
		public string length { get; set; }
	}

	public class Variant
	{
		public string itemVariantId { get; set; }
		public string sku { get; set; }
		public string gran { get; set; }
		public ShippingWeight shippingWeight { get; set; }
		public DefaultPricing defaultPricing { get; set; }
		public List<string> variantValues { get; set; }
		public Quantity quantity { get; set; }
		public ShippingDimension shippingDimension { get; set; }
	}

	public class RakutenCategory
	{
		public int rakutenCategoryId { get; set; }
	}

	public class Name3
	{
		public string value { get; set; }
	}

	public class Discount
	{
		public string discountType { get; set; }
		public string value { get; set; }
		public string pointExpiryTime { get; set; }
	}

	public class Parameters
	{
		public string couponCode { get; set; }
		public string minimumSpend { get; set; }
		public bool isMemberOnly { get; set; }
		public string reuseLimit { get; set; }
		public bool isVisible { get; set; }
		public string rewardLimit { get; set; }
		public bool? isPrivate { get; set; }
	}

	public class Campaign
	{
		public string campaignId { get; set; }
		public Name3 name { get; set; }
		public string campaignType { get; set; }
		public string liveStartTime { get; set; }
		public string liveEndTime { get; set; }
		public Discount discount { get; set; }
		public Parameters parameters { get; set; }
		public string campaignUrl { get; set; }
		public List<string> shopIds { get; set; }
		public string minimumSpend { get; set; }
		public List<string> shopShippingMethodIds { get; set; }
		public List<string> itemIds { get; set; }
	}

	public class NameMultiLang
	{
		public string value { get; set; }
	}

	public class ShopShippingMethod
	{
		public string shippingMethodId { get; set; }
		public string shopShippingMethodId { get; set; }
		public string name { get; set; }
		public NameMultiLang nameMultiLang { get; set; }
		public bool isDomestic { get; set; }
		public bool isIntl { get; set; }
	}

	public class NameMultiLang2
	{
		public string id_ID { get; set; }
		public string value { get; set; }
	}

	public class ShopPaymentMethod
	{
		public string shopPaymentMethodId { get; set; }
		public string name { get; set; }
		public NameMultiLang2 nameMultiLang { get; set; }
		public string priority { get; set; }
		public bool isDefaultPurchase { get; set; }
	}

	public class ShopItem
	{
		public string itemId { get; set; }
		public string merchantId { get; set; }
		public string shopId { get; set; }
		public string baseSku { get; set; }
		public string name { get; set; }
		public string tagline { get; set; }
		public string descriptionHtml { get; set; }
		public string brand { get; set; }
		public Duration duration { get; set; }
		public string searchableStartTime { get; set; }
		public string shippingStartTime { get; set; }
		public int rakutenCategoryId { get; set; }
		public List<ShopCategory> shopCategories { get; set; }
		public List<Image> images { get; set; }
		public List<string> variantLabels { get; set; }
		public List<Variant> variants { get; set; }
		public string lastModified { get; set; }
		public RakutenCategory rakutenCategory { get; set; }
		public List<Campaign> campaigns { get; set; }
		public List<ShopShippingMethod> shopShippingMethods { get; set; }
		public List<ShopPaymentMethod> shopPaymentMethods { get; set; }
		public bool? isInventoryHidden { get; set; }
		public bool? inventoryHidden { get; set; }
	}

	public class Response
	{
		public Shop shop { get; set; }
		public int status { get; set; }
		public ShopItem shopItem { get; set; }
	}

	public class Resource
	{
		public string name { get; set; }
		public Response response { get; set; }
	}

	public class RootObject
	{
		public int status { get; set; }
		public List<Resource> resources { get; set; }
	}

}

