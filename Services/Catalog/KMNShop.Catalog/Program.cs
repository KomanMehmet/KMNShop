using KMNShop.Catalog.Services.BannerServices;
using KMNShop.Catalog.Services.BrandServices;
using KMNShop.Catalog.Services.CategoryServices;
using KMNShop.Catalog.Services.FooterAboutServices;
using KMNShop.Catalog.Services.FooterContactServices;
using KMNShop.Catalog.Services.FooterLinkServices;
using KMNShop.Catalog.Services.FooterTweetConfigServices;
using KMNShop.Catalog.Services.PaymentMethodServices;
using KMNShop.Catalog.Services.ProductDetailServices;
using KMNShop.Catalog.Services.ProductImageServices;
using KMNShop.Catalog.Services.ProductServices;
using KMNShop.Catalog.Services.ProductSpecificationServices;
using KMNShop.Catalog.Services.ProductVariantVariantServices;
using KMNShop.Catalog.Services.PromoBannerServices;
using KMNShop.Catalog.Services.ServiceInfoServices;
using KMNShop.Catalog.Services.SocialMediaLinkServices;
using KMNShop.Catalog.Services.SubscriberServices;
using KMNShop.Catalog.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IFooterAboutService, FooterAboutService>();
builder.Services.AddScoped<IFooterContactService, FooterContactService>();
builder.Services.AddScoped<IFooterLinkService, FooterLinkService>();
builder.Services.AddScoped<IFooterTweetConfigService, FooterTweetConfigService>();
builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductDetailService, ProductDetailService>();
builder.Services.AddScoped<IProductImageService, ProductImageService>();
builder.Services.AddScoped<IProductSpecificationService, ProductSpecificationService>();
builder.Services.AddScoped<IProductVariantService, ProductVariantService>();
builder.Services.AddScoped<IPromoBannerService, PromoBannerService>();
builder.Services.AddScoped<IServiceInfoService, ServiceInfoService>();
builder.Services.AddScoped<ISocialMediaLinkService, SocialMediaLinkService>();
builder.Services.AddScoped<ISubscriberService, SubscriberService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
