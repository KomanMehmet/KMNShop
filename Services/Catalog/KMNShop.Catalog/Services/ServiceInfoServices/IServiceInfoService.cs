using KMNShop.Catalog.Dtos.ServiceInfoDtos;

namespace KMNShop.Catalog.Services.ServiceInfoServices
{
    public interface IServiceInfoService
    {
        Task<List<ResultServiceInfoDto>> GetAllServiceInfoAsync();

        Task CreateServiceInfoAsync(CreateServiceInfoDto createServiceInfoDto);

        Task UpdateServiceInfoAsync(UpdateServiceInfoDto updateServiceInfoDto);

        Task DeleteServiceInfoAsync(string id);

        Task<GetByIdServiceInfoDto> GetServiceInfoByIdAsync(string id);
    }
}
