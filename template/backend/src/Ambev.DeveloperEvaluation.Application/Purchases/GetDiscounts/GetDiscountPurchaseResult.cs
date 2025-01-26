namespace Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts
{
    public class GetDiscountPurchaseResult
    {
        public decimal TotalSale { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSaleItems { get; set; }
        public bool Canceled { get; set; }
        public List<ProductQuantityResult> Products { get; set; }
    }

    public class ProductQuantityResult
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
