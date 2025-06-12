namespace KMNShop.Catalog.Dtos.PaymentMethodDtos
{
    public class UpdatePaymentMethodDto
    {
        public string PaymentMethodID { get; set; }

        public string Icon { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
