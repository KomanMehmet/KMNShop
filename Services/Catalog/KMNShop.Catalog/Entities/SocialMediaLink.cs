using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class SocialMediaLink
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SocialMediaLinkID { get; set; }

        public string Icon { get; set; }

        public bool IsActive { get; set; }
    }
}
