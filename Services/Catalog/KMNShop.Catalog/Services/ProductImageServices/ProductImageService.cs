using AutoMapper;
using KMNShop.Catalog.Dtos.ProductImageDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMongoCollection<ProductImage> _productImagesCollection;
        private readonly IMapper _mapper;

        public ProductImageService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productImagesCollection = database.GetCollection<ProductImage>(databaseSettings.ProductImageCollectionName);

            _mapper = mapper;
        }

        public async Task CreateProductImageAsync(CreateProductImageDto createProductImageDto)
        {
            var value = _mapper.Map<ProductImage>(createProductImageDto);

            await _productImagesCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductImageAsync(string id)
        {
            await _productImagesCollection.DeleteOneAsync(pd => pd.ProductImageID == id);
        }

        public async Task<List<ResultProductImageDto>> GetAllProductImagesAsync()
        {
            var values = await _productImagesCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultProductImageDto>>(values);
        }

        public async Task<GetByIdProductImageDto> GetProductImageByIdAsync(string id)
        {
            var value = await _productImagesCollection.Find(pd => pd.ProductImageID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdProductImageDto>(value);
        }

        public async Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
        {
            var value = _mapper.Map<ProductImage>(updateProductImageDto);

            await _productImagesCollection.FindOneAndReplaceAsync(x =>
            x.ProductImageID == updateProductImageDto.ProductImageID, value);

        }
    }
}
