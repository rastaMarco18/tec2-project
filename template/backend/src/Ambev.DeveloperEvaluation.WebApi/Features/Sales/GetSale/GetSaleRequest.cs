namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

public class GetSaleRequest 
{
    public Guid? Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public decimal? TotalSale { get; set; }
    public bool? Canceled { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
}


