using KMNShop.Catalog.Dtos.ProductSpecificationDtos;

namespace KMNShop.Catalog.Services.ProductSpecificationServices
{
    public interface IProductSpecificationService
    {
        Task<List<ResultProductSpecificationDto>> GetAllProductSpecificationsAsync();

        Task CreateProductSpecificationAsync(CreateProductSpecificationDto createProductSpecificationDto);

        Task UpdateProductSpecificationAsync(UpdateProductSpecificationDto updateProductSpecificationDto);

        Task DeleteProductSpecificationAsync(string id);

        Task<GetByIdProductSpecificationDto> GetProductSpecificationByIdAsync(string id);
    }
}
