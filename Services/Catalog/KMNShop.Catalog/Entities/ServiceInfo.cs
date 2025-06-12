using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class ServiceInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceInfoID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Icon { get; set; }
    }
}
