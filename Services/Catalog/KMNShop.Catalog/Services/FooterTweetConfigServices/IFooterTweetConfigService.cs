using KMNShop.Catalog.Dtos.FooterTweetConfigDtos;

namespace KMNShop.Catalog.Services.FooterTweetConfigServices
{
    public interface IFooterTweetConfigService
    {
        Task<List<ResultFooterTweetConfigDto>> GetFooterTweetConfigAsync();

        Task CreateFooterTweetConfigAsync(CreateFooterTweetConfigDto createFooterTweetConfigDto);

        Task UpdateFooterTweetConfigAsync(UpdateFooterTweetConfigDto updateFooterTweetConfigDto);

        Task DeleteFooterTweetConfigAsync(string id);

        Task<GetByIdFooterTweetConfigDto> GetFooterTweetConfigByIdAsync(string id);
    }
}
