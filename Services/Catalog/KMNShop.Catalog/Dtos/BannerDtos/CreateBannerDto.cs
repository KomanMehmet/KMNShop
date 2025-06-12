namespace KMNShop.Catalog.Dtos.BannerDtos
{
    public class CreateBannerDto
    {
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
