using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class PaymentMethod
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string PaymentMethodID { get; set; }

        public string Icon { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
