using AutoMapper;
using KMNShop.Catalog.Dtos.ProductSpecificationDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.ProductSpecificationServices
{
    public class ProductSpecificationService : IProductSpecificationService
    {
        private readonly IMongoCollection<ProductSpecification> _productSpecificationsCollection;
        private readonly IMapper _mapper;

        public ProductSpecificationService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productSpecificationsCollection = database.GetCollection<ProductSpecification>(databaseSettings.ProductSpecificationCollectionName);

            _mapper = mapper;
        }

        public async Task CreateProductSpecificationAsync(CreateProductSpecificationDto createProductSpecificationDto)
        {
            var value = _mapper.Map<ProductSpecification>(createProductSpecificationDto);

            await _productSpecificationsCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductSpecificationAsync(string id)
        {
            await _productSpecificationsCollection.DeleteOneAsync(pd => pd.ProductSpecificationID == id);
        }

        public async Task<List<ResultProductSpecificationDto>> GetAllProductSpecificationsAsync()
        {
            var values = await _productSpecificationsCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultProductSpecificationDto>>(values);
        }

        public async Task<GetByIdProductSpecificationDto> GetProductSpecificationByIdAsync(string id)
        {
            var value = await _productSpecificationsCollection.Find(pd => pd.ProductSpecificationID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdProductSpecificationDto>(value);
        }

        public async Task UpdateProductSpecificationAsync(UpdateProductSpecificationDto updateProductSpecificationDto)
        {
            var value = _mapper.Map<ProductSpecification>(updateProductSpecificationDto);

            await _productSpecificationsCollection.FindOneAndReplaceAsync(x =>
            x.ProductSpecificationID == updateProductSpecificationDto.ProductSpecificationID, value);

        }
    }
}
