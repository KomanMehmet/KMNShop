using KMNShop.Catalog.Dtos.ProductSpecificationDtos;

namespace KMNShop.Catalog.Dtos.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public string ProductDetailID { get; set; }

        public string Description { get; set; }

        public List<ResultProductSpecificationDto> ProductSpecifications { get; set; }

        public string ProductID { get; set; }
    }
}
