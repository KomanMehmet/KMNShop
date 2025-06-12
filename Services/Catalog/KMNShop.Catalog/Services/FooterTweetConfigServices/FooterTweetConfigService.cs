using AutoMapper;
using KMNShop.Catalog.Dtos.FooterTweetConfigDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.FooterTweetConfigServices
{
    public class FooterTweetConfigService : IFooterTweetConfigService
    {
        private readonly IMongoCollection<FooterTweetConfig> _footerTweetConfigCollection;
        private readonly IMapper _mapper;

        public FooterTweetConfigService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerTweetConfigCollection = database.GetCollection<FooterTweetConfig>(databaseSettings.FooterTweetConfigCollectionName);
            
            _mapper = mapper;
        }

        public async Task CreateFooterTweetConfigAsync(CreateFooterTweetConfigDto createFooterTweetConfigDto)
        {
            var value = _mapper.Map<FooterTweetConfig>(createFooterTweetConfigDto);

            await _footerTweetConfigCollection.InsertOneAsync(value);
        }

        public async Task DeleteFooterTweetConfigAsync(string id)
        {
            await _footerTweetConfigCollection.DeleteOneAsync(x => x.FooterTweetConfigID == id);
        }

        public async Task<List<ResultFooterTweetConfigDto>> GetFooterTweetConfigAsync()
        {
            var values = await _footerTweetConfigCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultFooterTweetConfigDto>>(values);
        }

        public async Task<GetByIdFooterTweetConfigDto> GetFooterTweetConfigByIdAsync(string id)
        {
            var value = await _footerTweetConfigCollection.Find(x => x.FooterTweetConfigID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdFooterTweetConfigDto>(value);
        }

        public async Task UpdateFooterTweetConfigAsync(UpdateFooterTweetConfigDto updateFooterTweetConfigDto)
        {
            var value = _mapper.Map<FooterTweetConfig>(updateFooterTweetConfigDto);

            await _footerTweetConfigCollection.FindOneAndReplaceAsync(x => x.FooterTweetConfigID == updateFooterTweetConfigDto.FooterTweetConfigID, value);
        }
    }
}
