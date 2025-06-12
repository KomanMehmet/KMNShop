using AutoMapper;
using KMNShop.Catalog.Dtos.BannerDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly IMongoCollection<Banner> _bannersCollection;
        private readonly IMapper _mapper;

        public BannerService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _bannersCollection = database.GetCollection<Banner>(databaseSettings.BannerCollectionName);

            _mapper = mapper;
        }

        public async Task CreateBannerAsync(CreateBannerDto createBannerDto)
        {
            var value = _mapper.Map<Banner>(createBannerDto);

            await _bannersCollection.InsertOneAsync(value);
        }

        public async Task DeleteBannerAsync(string id)
        {
            await _bannersCollection.DeleteOneAsync(b => b.BannerID == id);
        }

        public async Task<List<ResultBannerDto>> GetAllBannerAsync()
        {
            var values = await _bannersCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultBannerDto>>(values);
        }

        public async Task<GetByIdBannerDto> GetByIdBannerAsync(string id)
        {
            var value = await _bannersCollection.Find(b => b.BannerID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdBannerDto>(value);
        }

        public async Task UpdateBannerAsync(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);

            await _bannersCollection.FindOneAndReplaceAsync(x => x.BannerID == updateBannerDto.BannerID, value);
        }
    }
}
