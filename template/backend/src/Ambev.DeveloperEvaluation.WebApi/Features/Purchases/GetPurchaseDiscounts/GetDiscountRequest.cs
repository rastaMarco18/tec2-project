namespace Ambev.DeveloperEvaluation.WebApi.Features.Discounts.GetDiscount;

public class GetDiscountRequest
{
    public List<ProductPurchaseRequest> Products { get; set; }
}

public class ProductPurchaseRequest
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
