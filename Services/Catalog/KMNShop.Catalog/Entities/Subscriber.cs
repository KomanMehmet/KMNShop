using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class Subscriber
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubscriberID { get; set; }

        public string Email { get; set; }

        public DateTime SubscribedAt { get; set; }

        public bool IsConfirmed { get; set; }

        public string ConfirmationToken { get; set; }
    }
}
