﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KMNShop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductDetailID { get; set; }

        public string Description { get; set; }

        public List<ProductSpecification> ProductSpecification { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
