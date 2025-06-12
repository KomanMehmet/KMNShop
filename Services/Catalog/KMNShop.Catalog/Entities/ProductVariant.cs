using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class ProductVariant
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductVariantID { get; set; }

        public string Color { get; set; }

        public string? Size { get; set; }

        public int Stock { get; set; }

        public string ProductID { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
