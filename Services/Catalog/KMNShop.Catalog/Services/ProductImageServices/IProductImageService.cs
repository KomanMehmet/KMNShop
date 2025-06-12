using KMNShop.Catalog.Dtos.ProductImageDtos;
using KMNShop.Catalog.Dtos.ProductImageDtos;

namespace KMNShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImagesAsync();

        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);

        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);

        Task DeleteProductImageAsync(string id);

        Task<GetByIdProductImageDto> GetProductImageByIdAsync(string id);
    }
}
