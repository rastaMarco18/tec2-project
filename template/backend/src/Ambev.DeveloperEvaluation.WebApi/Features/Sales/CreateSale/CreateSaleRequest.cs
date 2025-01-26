namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequest
{
    public decimal TotalSale { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSaleItems { get; set; }
    public List<ProductQuantityRequest> Products { get; set; }
}

public class ProductQuantityRequest
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
