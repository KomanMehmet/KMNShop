namespace KMNShop.Catalog.Dtos.PaymentMethodDtos
{
    public class GetByIdPaymentMethodDto
    {
        public string PaymentMethodID { get; set; }

        public string Icon { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
