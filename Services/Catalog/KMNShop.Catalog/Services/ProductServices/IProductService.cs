﻿using KMNShop.Catalog.Dtos.ProductDtos;

namespace KMNShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);

        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAsync(string id);

        Task<GetByIdProductDto> GetProductByIdAsync(string id);
    }
}
