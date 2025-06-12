using KMNShop.Catalog.Dtos.SocialMediaLinkDtos;

namespace KMNShop.Catalog.Services.SocialMediaLinkServices
{
    public interface ISocialMediaLinkService
    {
        Task<List<ResultSocialMediaLinkDto>> GetAllSocialMediaLinkAsync();

        Task CreateSocialMediaLinkAsync(CreateSocialMediaLinkDto createSocialMediaLinkDto);

        Task UpdateSocialMediaLinkAsync(UpdateSocialMediaLinkDto updateSocialMediaLinkDto);

        Task DeleteSocialMediaLinkAsync(string id);

        Task<GetByIdSocialMediaLinkDto> GetSocialMediaLinkByIdAsync(string id);
    }
}
