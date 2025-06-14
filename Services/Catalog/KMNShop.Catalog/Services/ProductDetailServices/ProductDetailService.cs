﻿using AutoMapper;
using KMNShop.Catalog.Dtos.ProductDetailDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.ProductDetailServices
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly IMongoCollection<ProductDetail> _productDetailsCollection;
        private readonly IMapper _mapper;

        public ProductDetailService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productDetailsCollection = database.GetCollection<ProductDetail>(databaseSettings.ProductDetailCollectionName);

            _mapper = mapper;
        }

        public async Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
        {
            var value = _mapper.Map<ProductDetail>(createProductDetailDto);

            await _productDetailsCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductDetailAsync(string id)
        {
            await _productDetailsCollection.DeleteOneAsync(pd => pd.ProductDetailID == id);
        }

        public async Task<List<ResultProductDetailDto>> GetAllProductDetailsAsync()
        {
            var values = await _productDetailsCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultProductDetailDto>>(values);
        }

        public async Task<GetByIdProductDetailDto> GetProductDetailByIdAsync(string id)
        {
            var value = await _productDetailsCollection.Find(pd => pd.ProductDetailID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdProductDetailDto>(value);
        }

        public async Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
        {
            var value = _mapper.Map<ProductDetail>(updateProductDetailDto);

            await _productDetailsCollection.FindOneAndReplaceAsync(x =>
            x.ProductDetailID == updateProductDetailDto.ProductDetailID, value);

        }
    }
}
