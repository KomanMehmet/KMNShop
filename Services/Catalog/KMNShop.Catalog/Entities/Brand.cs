using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class Brand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BrandID { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
