using KMNShop.Catalog.Dtos.SubscriberDtos;

namespace KMNShop.Catalog.Services.SubscriberServices
{
    public interface ISubscriberService
    {
        Task<List<ResultSubscriberDto>> GetAllSubscriberAsync();

        Task CreateSubscriberAsync(CreateSubscriberDto createSubscriberDto);

        Task UpdateSubscriberAsync(UpdateSubscriberDto updateSubscriberDto);

        Task DeleteSubscriberAsync(string id);

        Task<GetByIdSubscriberDto> GetSubscriberByIdAsync(string id);
    }
}
