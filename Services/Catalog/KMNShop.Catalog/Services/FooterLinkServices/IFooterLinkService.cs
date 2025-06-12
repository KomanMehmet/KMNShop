using KMNShop.Catalog.Dtos.FooterLinkDtos;
using KMNShop.Catalog.Entities;

namespace KMNShop.Catalog.Services.FooterLinkServices
{
    public interface IFooterLinkService
    {
        Task<List<ResultFooterLinkDto>> GetFooterLinkAsync();

        Task CraeteFooterLinkAsync(CreateFooterLinkDto createFooterLinkDto);

        Task UpdateFooterLinkAsync(UpdateFooterLinkDto updateFooterLinkDto);

        Task DeleteFooterLinkAsync(string id);

        Task<GetByIdFooterLinkDto> GetByIdFooterLinAsync(string id);
    }
}
