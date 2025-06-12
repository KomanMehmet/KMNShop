using KMNShop.Catalog.Dtos.BannerDtos;

namespace KMNShop.Catalog.Services.BannerServices
{
    public interface IBannerService
    {
        Task<List<ResultBannerDto>> GetAllBannerAsync();

        Task CreateBannerAsync(CreateBannerDto createBannerDto);

        Task UpdateBannerAsync(UpdateBannerDto updateBannerDto);

        Task DeleteBannerAsync(string id);

        Task<GetByIdBannerDto> GetByIdBannerAsync(string id);
    }
}
