using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }

        public string Name { get; set; }

        public string? ParentCategoryID { get; set; }

        [BsonIgnore]
        public List<Category> SubCategories { get; set; }

        public bool IsSelectable { get; set; }
    }
}
