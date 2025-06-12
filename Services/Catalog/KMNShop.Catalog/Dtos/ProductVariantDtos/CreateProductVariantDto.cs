namespace KMNShop.Catalog.Dtos.ProductVariantDtos
{
    public class CreateProductVariantDto
    {
        public string Color { get; set; }

        public string? Size { get; set; }

        public int Stock { get; set; }

        public string ProductID { get; set; }
    }
}
