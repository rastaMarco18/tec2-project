namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

public class CompleteSaleCommand
{
    public Guid SaleId { get; set; }
    public List<ProductQuantity> Products { get; set; }
}
