namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

public class CreateSaleResult
{
    public Guid Id { get; set; }
    public decimal TotalSale { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSaleItems { get; set; }
    public bool Canceled { get; set; }
    public DateTime CreatedAt { get; set; }
}
