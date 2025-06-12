using KMNShop.Catalog.Dtos.FooterAboutDtos;

namespace KMNShop.Catalog.Services.FooterAboutServices
{
    public interface IFooterAboutService
    {
        Task<List<ResultFooterAboutDto>> GetFooterAboutAsync();

        Task CreateFooterAboutAsync(CreateFooterAboutDto createFooterAboutDto);

        Task UpdateFooterAboutAsync(UpdateFooterAboutDto updateFooterAboutDto);

        Task DeleteFooterAboutAsync(string id);

        Task<GetByIdFooterAboutDto> GetByIdFooterAboutAsync(string id);
    }
}
