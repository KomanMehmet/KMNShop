using AutoMapper;
using KMNShop.Catalog.Dtos.PromoBannerDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.PromoBannerServices
{
    public class PromoBannerService : IPromoBannerService
    {
        private readonly IMongoCollection<PromoBanner> _promoBannerCollection;
        private readonly IMapper _mapper;

        public PromoBannerService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _promoBannerCollection = database.GetCollection<PromoBanner>(databaseSettings.PromoBannerCollectionName);

            _mapper = mapper;
        }

        public async Task CreatePromoBannerAsync(CreatePromoBannerDto createPromoBannerDto)
        {
            var value = _mapper.Map<PromoBanner>(createPromoBannerDto);

            await _promoBannerCollection.InsertOneAsync(value);
        }

        public async Task DeletePromoBannerAsync(string id)
        {
            await _promoBannerCollection.DeleteOneAsync(x => x.PromoBannerID == id);
        }

        public async Task<List<ResultPromoBannerDto>> GetAllPromoBannerAsync()
        {
            var values = await _promoBannerCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultPromoBannerDto>>(values);
        }

        public async Task<GetByIdPromoBannerDto> GetPromoBannerByIdAsync(string id)
        {
            var value = await _promoBannerCollection.Find(x => x.PromoBannerID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdPromoBannerDto>(value);
        }

        public async Task UpdatePromoBannerAsync(UpdatePromoBannerDto updatePromoBannerDto)
        {
            var value = _mapper.Map<PromoBanner>(updatePromoBannerDto);

            await _promoBannerCollection.FindOneAndReplaceAsync(x => x.PromoBannerID == updatePromoBannerDto.PromoBannerID, value);
        }
    }
}
