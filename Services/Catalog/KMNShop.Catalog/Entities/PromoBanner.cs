using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class PromoBanner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PromoBannerID { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }
    }
}
