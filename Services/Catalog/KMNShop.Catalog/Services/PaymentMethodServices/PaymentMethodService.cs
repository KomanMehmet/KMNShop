using AutoMapper;
using KMNShop.Catalog.Dtos.PaymentMethodDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.PaymentMethodServices
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IMongoCollection<PaymentMethod> _paymentMethodsCollection;
        private readonly IMapper _mapper;

        public PaymentMethodService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.DatabaseName);
            _paymentMethodsCollection = mongoDatabase.GetCollection<PaymentMethod>(databaseSettings.PaymentMethodCollectionName);

            _mapper = mapper;
        }

        public async Task CreatePaymentMethodAsync(CreatePaymentMethodDto createPaymentMethodDto)
        {
            var value = _mapper.Map<PaymentMethod>(createPaymentMethodDto);

            await _paymentMethodsCollection.InsertOneAsync(value);
        }

        public async Task DeletePaymentMethodAsync(string id)
        {
            await _paymentMethodsCollection.DeleteOneAsync(pm => pm.PaymentMethodID == id);
        }

        public async Task<List<ResultPaymentMethodDto>> GetAllPaymentMethodsAsync()
        {
            var values = await _paymentMethodsCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultPaymentMethodDto>>(values);
        }

        public async Task<GetByIdPaymentMethodDto> GetPaymentMethodByIdAsync(string id)
        {
            var value = await _paymentMethodsCollection.Find(pm => pm.PaymentMethodID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdPaymentMethodDto>(value);
        }

        public async Task UpdatePaymentMethodAsync(UpdatePaymentMethodDto updatePaymentMethodDto)
        {
            var value = _mapper.Map<PaymentMethod>(updatePaymentMethodDto);

            await _paymentMethodsCollection.FindOneAndReplaceAsync(x => x.PaymentMethodID == updatePaymentMethodDto.PaymentMethodID, value);

        }
    }
}
