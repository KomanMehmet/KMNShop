namespace KMNShop.Catalog.Dtos.BannerDtos
{
    public class GetByIdBannerDto
    {
        public string BannerID { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
