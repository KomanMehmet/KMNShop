namespace KMNShop.Catalog.Dtos.SubscriberDtos
{
    public class GetByIdSubscriberDto
    {
        public string SubscriberID { get; set; }

        public string Email { get; set; }

        public DateTime SubscribedAt { get; set; }

        public bool IsConfirmed { get; set; }

        public string ConfirmationToken { get; set; }
    }
}
