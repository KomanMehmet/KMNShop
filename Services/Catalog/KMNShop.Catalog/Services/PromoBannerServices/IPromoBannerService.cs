using KMNShop.Catalog.Dtos.PromoBannerDtos;

namespace KMNShop.Catalog.Services.PromoBannerServices
{
    public interface IPromoBannerService
    {
        Task<List<ResultPromoBannerDto>> GetAllPromoBannerAsync();

        Task CreatePromoBannerAsync(CreatePromoBannerDto createPromoBannerDto);

        Task UpdatePromoBannerAsync(UpdatePromoBannerDto updatePromoBannerDto);

        Task DeletePromoBannerAsync(string id);

        Task<GetByIdPromoBannerDto> GetPromoBannerByIdAsync(string id);
    }
}
