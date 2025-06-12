namespace KMNShop.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string BannerCollectionName { get; set; }

        public string BrandCollectionName { get; set; }

        public string CategoryCollectionName { get; set; }

        public string FooterAboutCollectionName { get; set; }

        public string FooterContactCollectionName { get; set; }

        public string FooterLinkCollectionName { get; set; }

        public string FooterTweetConfigCollectionName { get; set; }

        public string PaymentMethodCollectionName { get; set; }

        public string ProductCollectionName { get; set; }

        public string ProductDetailCollectionName { get; set; }

        public string ProductImageCollectionName { get; set; }

        public string ProductSpecificationCollectionName { get; set; }

        public string ProductVariantCollectionName { get; set; }

        public string PromoBannerCollectionName { get; set; }

        public string ServiceInfoCollectionName { get; set; }

        public string SocialMediaLinkCollectionName { get; set; }

        public string SubscriberCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
