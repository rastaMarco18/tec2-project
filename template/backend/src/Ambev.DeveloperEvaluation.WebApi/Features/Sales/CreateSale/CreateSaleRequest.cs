namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequest
{   
    //UMA ABORDAGEM RUIM, PODERIA TER PEGO DO TOKEN O ID, MAS NÃO TIVE TEMPO
    public string UserEmail { get; set; } 
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
