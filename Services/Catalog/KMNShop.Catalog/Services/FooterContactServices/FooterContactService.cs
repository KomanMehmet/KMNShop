using AutoMapper;
using KMNShop.Catalog.Dtos.FooterContactDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.FooterContactServices
{
    public class FooterContactService : IFooterContactService
    {
        private readonly IMongoCollection<FooterContact> _footerContactCollection;
        private readonly IMapper _mapper;

        public FooterContactService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(databaseSettings.DatabaseName);
            _footerContactCollection = mongoDatabase.GetCollection<FooterContact>(databaseSettings.FooterContactCollectionName);

            _mapper = mapper;
        }

        public async Task CraeteFooterContactAsync(CreateFooterContactDto createFooterContactDto)
        {
            var value = _mapper.Map<FooterContact>(createFooterContactDto);

            await _footerContactCollection.InsertOneAsync(value);
        }

        public async Task DeleteFooterContactAsync(string id)
        {
            await _footerContactCollection.DeleteOneAsync(f => f.FooterContactID == id);
        }

        public async Task<List<ResultFooterContactDto>> GetFooterContactAsync()
        {
            var values = await _footerContactCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultFooterContactDto>>(values);
        }

        public async Task<GetByIdFooterContactDto> GetFooterContactByIdAsync(string id)
        {
            var value = await _footerContactCollection.Find(f => f.FooterContactID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdFooterContactDto>(value);
        }

        public async Task UpdateFooterContactAsync(UpdateFooterContactDto updateFooterContactDto)
        {
            var value = _mapper.Map<FooterContact>(updateFooterContactDto);

            await _footerContactCollection.FindOneAndReplaceAsync(x => x.FooterContactID == updateFooterContactDto.FooterContactID, value);
        }
    }
}
