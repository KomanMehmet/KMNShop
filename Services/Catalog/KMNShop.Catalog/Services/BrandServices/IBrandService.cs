﻿using KMNShop.Catalog.Dtos.BrandDtos;

namespace KMNShop.Catalog.Services.BrandServices
{
    public interface IBrandService
    {
        Task<List<ResultBrandDto>> GetAllBrandAsync();

        Task CreateBrandAsync(CreateBrandDto createBrandDto);

        Task UpdateBrandAsync(UpdateBrandDto updateBrandDto);

        Task DeleteBrandAsync(string id);

        Task<GetByIdBrandDto> GetByIdBrandAsync(string id);
    }
}
