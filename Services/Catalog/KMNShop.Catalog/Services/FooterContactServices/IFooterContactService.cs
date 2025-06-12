using KMNShop.Catalog.Dtos.FooterContactDtos;

namespace KMNShop.Catalog.Services.FooterContactServices
{
    public interface IFooterContactService
    {
        Task<List<ResultFooterContactDto>> GetFooterContactAsync();

        Task CraeteFooterContactAsync(CreateFooterContactDto createFooterContactDto);

        Task UpdateFooterContactAsync(UpdateFooterContactDto updateFooterContactDto);

        Task DeleteFooterContactAsync(string id);

        Task<GetByIdFooterContactDto> GetFooterContactByIdAsync(string id);
    }
}
