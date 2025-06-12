using AutoMapper;
using KMNShop.Catalog.Dtos.SubscriberDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.SubscriberServices
{
    public class SubscriberService : ISubscriberService
    {
        private readonly IMongoCollection<Subscriber> _subscriberCollection;
        private readonly IMapper _mapper;

        public SubscriberService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _subscriberCollection = database.GetCollection<Subscriber>(databaseSettings.SubscriberCollectionName);

            _mapper = mapper;
        }

        public async Task CreateSubscriberAsync(CreateSubscriberDto createSubscriberDto)
        {
            var value = _mapper.Map<Subscriber>(createSubscriberDto);

            await _subscriberCollection.InsertOneAsync(value);
        }

        public async Task DeleteSubscriberAsync(string id)
        {
            await _subscriberCollection.DeleteOneAsync(x => x.SubscriberID == id);
        }

        public async Task<List<ResultSubscriberDto>> GetAllSubscriberAsync()
        {
            var values = await _subscriberCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultSubscriberDto>>(values);
        }

        public async Task<GetByIdSubscriberDto> GetSubscriberByIdAsync(string id)
        {
            var value = await _subscriberCollection.Find(x => x.SubscriberID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdSubscriberDto>(value);
        }

        public async Task UpdateSubscriberAsync(UpdateSubscriberDto updateSubscriberDto)
        {
            var value = _mapper.Map<Subscriber>(updateSubscriberDto);

            await _subscriberCollection.FindOneAndReplaceAsync(x => x.SubscriberID == updateSubscriberDto.SubscriberID, value);
        }
    }
}
