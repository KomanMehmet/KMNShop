using AutoMapper;
using KMNShop.Catalog.Dtos.BrandDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.BrandServices
{
    public class BrandService : IBrandService
    {
        private readonly IMongoCollection<Brand> _brandsCollection;
        private readonly IMapper _mapper;

        public BrandService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _brandsCollection = database.GetCollection<Brand>(databaseSettings.BrandCollectionName);

            _mapper = mapper;
        }

        public async Task CreateBrandAsync(CreateBrandDto createBrandDto)
        {
            var value = _mapper.Map<Brand>(createBrandDto);

            await _brandsCollection.InsertOneAsync(value);
        }

        public async Task DeleteBrandAsync(string id)
        {
            await _brandsCollection.DeleteOneAsync(b => b.BrandID == id);
        }

        public async Task<List<ResultBrandDto>> GetAllBrandAsync()
        {
            var values = await _brandsCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultBrandDto>>(values);
        }

        public async Task<GetByIdBrandDto> GetByIdBrandAsync(string id)
        {
            var value = await _brandsCollection.Find(b => b.BrandID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdBrandDto>(value);
        }

        public async Task UpdateBrandAsync(UpdateBrandDto updateBrandDto)
        {
            var value = _mapper.Map<Brand>(updateBrandDto);

            await _brandsCollection.FindOneAndReplaceAsync(x => x.BrandID == updateBrandDto.BrandID, value);
        }
    }
}
