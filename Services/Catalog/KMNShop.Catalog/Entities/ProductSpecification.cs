using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class ProductSpecification
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductSpecificationID { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailID { get; set; }

        [BsonIgnore]
        public ProductDetail ProductDetail { get; set; }
    }
}
