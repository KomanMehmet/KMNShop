using AutoMapper;
using KMNShop.Catalog.Dtos.ServiceInfoDtos;
using KMNShop.Catalog.Entities;
using KMNShop.Catalog.Settings;
using MongoDB.Driver;

namespace KMNShop.Catalog.Services.ServiceInfoServices
{
    public class ServiceInfoService : IServiceInfoService
    {
        private readonly IMongoCollection<ServiceInfo> _serviceInfoCollection;
        private readonly IMapper _mapper;

        public ServiceInfoService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _serviceInfoCollection = database.GetCollection<ServiceInfo>(databaseSettings.ServiceInfoCollectionName);

            _mapper = mapper;
        }

        public async Task CreateServiceInfoAsync(CreateServiceInfoDto createServiceInfoDto)
        {
            var value = _mapper.Map<ServiceInfo>(createServiceInfoDto);

            await _serviceInfoCollection.InsertOneAsync(value);
        }

        public async Task DeleteServiceInfoAsync(string id)
        {
            await _serviceInfoCollection.DeleteOneAsync(x => x.ServiceInfoID == id);
        }

        public async Task<List<ResultServiceInfoDto>> GetAllServiceInfoAsync()
        {
            var values = await _serviceInfoCollection.Find(x => true).ToListAsync();

            return _mapper.Map<List<ResultServiceInfoDto>>(values);
        }

        public async Task<GetByIdServiceInfoDto> GetServiceInfoByIdAsync(string id)
        {
            var value = await _serviceInfoCollection.Find(x => x.ServiceInfoID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdServiceInfoDto>(value);
        }

        public async Task UpdateServiceInfoAsync(UpdateServiceInfoDto updateServiceInfoDto)
        {
            var value = _mapper.Map<ServiceInfo>(updateServiceInfoDto);

            await _serviceInfoCollection.FindOneAndReplaceAsync(x => x.ServiceInfoID == updateServiceInfoDto.ServiceInfoID, value);
        }
    }
}
