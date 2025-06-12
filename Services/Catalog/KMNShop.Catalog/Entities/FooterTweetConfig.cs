using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class FooterTweetConfig
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterTweetConfigID { get; set; }

        public string TwitterUsername { get; set; }

        public bool IsEnabled { get; set; }
    }
}
