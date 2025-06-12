namespace KMNShop.Catalog.Dtos.SubscriberDtos
{
    public class CreateSubscriberDto
    {
        public string Email { get; set; }

        public DateTime SubscribedAt { get; set; }

        public bool IsConfirmed { get; set; }

        public string ConfirmationToken { get; set; }
    }
}
