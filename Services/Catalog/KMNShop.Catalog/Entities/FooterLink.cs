using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class FooterLink
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterLinkID { get; set; }

        public string Title { get; set; }

        public string Group { get; set; }
    }
}
