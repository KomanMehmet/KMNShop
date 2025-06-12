namespace KMNShop.Catalog.Dtos.ProductImageDtos
{
    public class GetByIdProductImageDto
    {
        public string ProductImageID { get; set; }

        public List<string> ImageUrls { get; set; }

        public string ProductID { get; set; }
    }
}
