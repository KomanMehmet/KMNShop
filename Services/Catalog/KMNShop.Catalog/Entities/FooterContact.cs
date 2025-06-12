using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class FooterContact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterContactID { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }
    }
}
