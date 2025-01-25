namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

public class GetSaleResponse 
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalSale { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSaleItems { get; set; }
    public bool Canceled { get; set; }
}
