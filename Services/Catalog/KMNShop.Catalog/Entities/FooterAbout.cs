using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class FooterAbout
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterAboutID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
