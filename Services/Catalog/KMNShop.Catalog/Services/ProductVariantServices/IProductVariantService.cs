using KMNShop.Catalog.Dtos.ProductVariantDtos;

namespace KMNShop.Catalog.Services.ProductVariantVariantServices
{
    public interface IProductVariantService
    {
        Task<List<ResultProductVariantDto>> GetAllProductVariantAsync();

        Task CreateProductVariantAsync(CreateProductVariantDto createProductVariantDto);

        Task UpdateProductVariantAsync(UpdateProductVariantDto updateProductVariantDto);

        Task DeleteProductVariantAsync(string id);

        Task<GetByIdProductVariantDto> GetProductVariantByIdAsync(string id);
    }
}
