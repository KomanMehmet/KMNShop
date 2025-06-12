using AutoMapper;
using KMNShop.Catalog.Dtos.FooterLinkDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.FooterLinkServices
{
    public class FooterLinkService : IFooterLinkService
    {
        private readonly IMongoCollection<FooterLink> _footerLinkCollection;
        private readonly IMapper _mapper;

        public FooterLinkService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _footerLinkCollection = database.GetCollection<FooterLink>(databaseSettings.FooterLinkCollectionName);

            _mapper = mapper;
        }

        public async Task CraeteFooterLinkAsync(CreateFooterLinkDto createFooterLinkDto)
        {
            var value = _mapper.Map<FooterLink>(createFooterLinkDto);

            await _footerLinkCollection.InsertOneAsync(value);
        }

        public async Task DeleteFooterLinkAsync(string id)
        {
            await _footerLinkCollection.DeleteOneAsync(x => x.FooterLinkID == id);
        }

        public async Task<GetByIdFooterLinkDto> GetByIdFooterLinAsync(string id)
        {
            var value = await _footerLinkCollection.Find(x => x.FooterLinkID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdFooterLinkDto>(value);
        }

        public async Task<List<ResultFooterLinkDto>> GetFooterLinkAsync()
        {
            var values = await _footerLinkCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultFooterLinkDto>>(values);
        }

        public async Task UpdateFooterLinkAsync(UpdateFooterLinkDto updateFooterLinkDto)
        {
            var value = _mapper.Map<FooterLink>(updateFooterLinkDto);

            await _footerLinkCollection.FindOneAndReplaceAsync(x => x.FooterLinkID == updateFooterLinkDto.FooterLinkID, value);
        }
    }
}
