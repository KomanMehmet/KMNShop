namespace KMNShop.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string CategoryID { get; set; }

        public string BrandID { get; set; }
    }
}
