namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchaseDiscounts
{
    public class GetPurchaseResponse
    {
        public decimal TotalSale { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSaleItems { get; set; }
        public bool Canceled { get; set; }
        public List<ProductQuantityResponse> Products { get; set; }
    }

    public class ProductQuantityResponse
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
