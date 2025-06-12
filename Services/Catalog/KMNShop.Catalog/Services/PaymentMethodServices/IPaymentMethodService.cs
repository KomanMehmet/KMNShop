using KMNShop.Catalog.Dtos.PaymentMethodDtos;
using KMNShop.Catalog.Entities;

namespace KMNShop.Catalog.Services.PaymentMethodServices
{
    public interface IPaymentMethodService
    {
        Task<List<ResultPaymentMethodDto>> GetAllPaymentMethodsAsync();

        Task CreatePaymentMethodAsync(CreatePaymentMethodDto createPaymentMethodDto);

        Task UpdatePaymentMethodAsync(UpdatePaymentMethodDto updatePaymentMethodDto);

        Task DeletePaymentMethodAsync(string id);

        Task<GetByIdPaymentMethodDto> GetPaymentMethodByIdAsync(string id);
    }
}
