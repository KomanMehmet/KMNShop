using AutoMapper;
using KMNShop.Catalog.Dtos.FooterAboutDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.FooterAboutServices
{
    public class FooterAboutService : IFooterAboutService
    {
        private readonly IMongoCollection<FooterAbout> _footerAboutCollection;
        private readonly IMapper _mapper;

        public FooterAboutService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerAboutCollection = database.GetCollection<FooterAbout>(databaseSettings.FooterAboutCollectionName);

            _mapper = mapper;
        }

        public async Task CreateFooterAboutAsync(CreateFooterAboutDto createFooterAboutDto)
        {
            var value = _mapper.Map<FooterAbout>(createFooterAboutDto);

            await _footerAboutCollection.InsertOneAsync(value);
        }

        public async Task DeleteFooterAboutAsync(string id)
        {
            await _footerAboutCollection.DeleteOneAsync(f => f.FooterAboutID == id);
        }

        public async Task<GetByIdFooterAboutDto> GetByIdFooterAboutAsync(string id)
        {
            var values = await _footerAboutCollection.Find(f => f.FooterAboutID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdFooterAboutDto>(values);
        }

        public async Task<List<ResultFooterAboutDto>> GetFooterAboutAsync()
        {
            var values = await _footerAboutCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultFooterAboutDto>>(values);
        }

        public async Task UpdateFooterAboutAsync(UpdateFooterAboutDto updateFooterAboutDto)
        {
            var value = _mapper.Map<FooterAbout>(updateFooterAboutDto);

            await _footerAboutCollection.FindOneAndReplaceAsync(x => x.FooterAboutID == updateFooterAboutDto.FooterAboutID, value);
        }
    }
}
