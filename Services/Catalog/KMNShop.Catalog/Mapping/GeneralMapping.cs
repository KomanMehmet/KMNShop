using AutoMapper;
using KMNShop.Catalog.Dtos.BannerDtos;
using KMNShop.Catalog.Dtos.BrandDtos;
using KMNShop.Catalog.Dtos.CategoryDtos;
using KMNShop.Catalog.Dtos.FooterAboutDtos;
using KMNShop.Catalog.Dtos.FooterContactDtos;
using KMNShop.Catalog.Dtos.FooterLinkDtos;
using KMNShop.Catalog.Dtos.FooterTweetConfigDtos;
using KMNShop.Catalog.Dtos.PaymentMethodDtos;
using KMNShop.Catalog.Dtos.ProductDetailDtos;
using KMNShop.Catalog.Dtos.ProductDtos;
using KMNShop.Catalog.Dtos.ProductImageDtos;
using KMNShop.Catalog.Dtos.ProductSpecificationDtos;
using KMNShop.Catalog.Dtos.ProductVariantDtos;
using KMNShop.Catalog.Dtos.PromoBannerDtos;
using KMNShop.Catalog.Dtos.ServiceInfoDtos;
using KMNShop.Catalog.Dtos.SocialMediaLinkDtos;
using KMNShop.Catalog.Dtos.SubscriberDtos;
using KMNShop.Catalog.Entities;

namespace KMNShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
            CreateMap<Banner, GetByIdBannerDto>().ReverseMap();

            CreateMap<Brand, ResultBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, GetByIdBrandDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<FooterAbout, ResultFooterAboutDto>().ReverseMap();
            CreateMap<FooterAbout, UpdateFooterAboutDto>().ReverseMap();
            CreateMap<FooterAbout, CreateFooterAboutDto>().ReverseMap();
            CreateMap<FooterAbout, GetByIdFooterAboutDto>().ReverseMap();

            CreateMap<FooterContact, ResultFooterContactDto>().ReverseMap();
            CreateMap<FooterContact, UpdateFooterContactDto>().ReverseMap();
            CreateMap<FooterContact, CreateFootercontactDto>().ReverseMap();
            CreateMap<FooterContact, GetByIdFooterContactDto>().ReverseMap();

            CreateMap<FooterLink, ResultFooterLinkDto>().ReverseMap();
            CreateMap<FooterLink, UpdateFooterLinkDto>().ReverseMap();
            CreateMap<FooterLink, CreateFooterLinkDto>().ReverseMap();
            CreateMap<FooterLink, GetByIdFooterLinkDto>().ReverseMap();

            CreateMap<FooterTweetConfig, ResultFooterTweetConfigDto>().ReverseMap();
            CreateMap<FooterTweetConfig, UpdateFooterTweetConfigDto>().ReverseMap();
            CreateMap<FooterTweetConfig, CreateFooterTweetConfigDto>().ReverseMap();
            CreateMap<FooterTweetConfig, GetByIdFooterTweetConfigDto>().ReverseMap();

            CreateMap<PaymentMethod, ResultPaymentMethodDto>().ReverseMap();
            CreateMap<PaymentMethod, UpdatePaymentMethodDto>().ReverseMap();
            CreateMap<PaymentMethod, CreatePaymentMethodDto>().ReverseMap();
            CreateMap<PaymentMethod, GetByIdPaymentMethodDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();

            CreateMap<ProductSpecification, ResultProductSpecificationDto>().ReverseMap();
            CreateMap<ProductSpecification, UpdateProductSpecificationDto>().ReverseMap();
            CreateMap<ProductSpecification, CreateProductSpecificationDto>().ReverseMap();
            CreateMap<ProductSpecification, GetByIdProductSpecificationDto>().ReverseMap();

            CreateMap<ProductVariant, ResultProductVariantDto>().ReverseMap();
            CreateMap<ProductVariant, UpdateProductVariantDto>().ReverseMap();
            CreateMap<ProductVariant, CreateProductVariantDto>().ReverseMap();
            CreateMap<ProductVariant, GetByIdProductVariantDto>().ReverseMap();

            CreateMap<PromoBanner, ResultPromoBannerDto>().ReverseMap();
            CreateMap<PromoBanner, UpdatePromoBannerDto>().ReverseMap();
            CreateMap<PromoBanner, CreatePromoBannerDto>().ReverseMap();
            CreateMap<PromoBanner, GetByIdPromoBannerDto>().ReverseMap();

            CreateMap<ServiceInfo, ResultServiceInfoDto>().ReverseMap();
            CreateMap<ServiceInfo, UpdateServiceInfoDto>().ReverseMap();
            CreateMap<ServiceInfo, CreateServiceInfoDto>().ReverseMap();
            CreateMap<ServiceInfo, GetByIdServiceInfoDto>().ReverseMap();

            CreateMap<SocialMediaLink, ResultSocialMediaLinkDto>().ReverseMap();
            CreateMap<SocialMediaLink, UpdateSocialMediaLinkDto>().ReverseMap();
            CreateMap<SocialMediaLink, CreateSocialMediaLinkDto>().ReverseMap();
            CreateMap<SocialMediaLink, GetByIdSocialMediaLinkDto>().ReverseMap();

            CreateMap<Subscriber, ResultSubscriberDto>().ReverseMap();
            CreateMap<Subscriber, UpdateSubscriberDto>().ReverseMap();
            CreateMap<Subscriber, CreateSubscriberDto>().ReverseMap();
            CreateMap<Subscriber, GetByIdSubscriberDto>().ReverseMap();
        }
    }
}
