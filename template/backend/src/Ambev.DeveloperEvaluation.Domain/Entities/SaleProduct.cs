namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class SaleProduct
{
    public Guid Id { get; set; }
    public Guid Sale_Id { get; set; }
    public Guid Product_Id { get; set; }
    public int Quantity { get; set; }
}
