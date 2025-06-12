using AutoMapper;
using KMNShop.Catalog.Dtos.ProductVariantDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.ProductVariantVariantServices
{
    public class ProductVariantService : IProductVariantService
    {
        private readonly IMongoCollection<ProductVariant> _ProductVariantCollection;
        private readonly IMapper _mapper;

        public ProductVariantService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _ProductVariantCollection = database.GetCollection<ProductVariant>(databaseSettings.ProductVariantCollectionName);

            _mapper = mapper;
        }

        public async Task CreateProductVariantAsync(CreateProductVariantDto createProductVariantDto)
        {
            var value = _mapper.Map<ProductVariant>(createProductVariantDto);

            await _ProductVariantCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductVariantAsync(string id)
        {
            await _ProductVariantCollection.DeleteOneAsync(x => x.ProductVariantID == id);
        }

        public async Task<List<ResultProductVariantDto>> GetAllProductVariantAsync()
        {
            var values = await _ProductVariantCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultProductVariantDto>>(values);
        }

        public async Task<GetByIdProductVariantDto> GetProductVariantByIdAsync(string id)
        {
            var value = await _ProductVariantCollection.Find(x => x.ProductVariantID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdProductVariantDto>(value);
        }

        public async Task UpdateProductVariantAsync(UpdateProductVariantDto updateProductVariantDto)
        {
            var value = _mapper.Map<ProductVariant>(updateProductVariantDto);

            await _ProductVariantCollection.FindOneAndReplaceAsync(x => x.ProductVariantID == updateProductVariantDto.ProductVariantID, value);
        }
    }
}
