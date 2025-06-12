using AutoMapper;
using KMNShop.Catalog.Dtos.SocialMediaLinkDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.SocialMediaLinkServices
{
    public class SocialMediaLinkService : ISocialMediaLinkService
    {
        private readonly IMongoCollection<SocialMediaLink> _socialMediaLinkCollection;
        private readonly IMapper _mapper;

        public SocialMediaLinkService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _socialMediaLinkCollection = database.GetCollection<SocialMediaLink>(databaseSettings.SocialMediaLinkCollectionName);

            _mapper = mapper;
        }

        public async Task CreateSocialMediaLinkAsync(CreateSocialMediaLinkDto createSocialMediaLinkDto)
        {
            var value = _mapper.Map<SocialMediaLink>(createSocialMediaLinkDto);

            await _socialMediaLinkCollection.InsertOneAsync(value);
        }

        public async Task DeleteSocialMediaLinkAsync(string id)
        {
            await _socialMediaLinkCollection.DeleteOneAsync(x => x.SocialMediaLinkID == id);
        }

        public async Task<List<ResultSocialMediaLinkDto>> GetAllSocialMediaLinkAsync()
        {
            var values = await _socialMediaLinkCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultSocialMediaLinkDto>>(values);
        }

        public async Task<GetByIdSocialMediaLinkDto> GetSocialMediaLinkByIdAsync(string id)
        {
            var value = await _socialMediaLinkCollection.Find(x => x.SocialMediaLinkID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdSocialMediaLinkDto>(value);
        }

        public async Task UpdateSocialMediaLinkAsync(UpdateSocialMediaLinkDto updateSocialMediaLinkDto)
        {
            var value = _mapper.Map<SocialMediaLink>(updateSocialMediaLinkDto);

            await _socialMediaLinkCollection.FindOneAndReplaceAsync(x => x.SocialMediaLinkID == updateSocialMediaLinkDto.SocialMediaLinkID, value);
        }
    }
}
