using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales;

public class GetSaleCommand : IRequest<GetSaleResult>
{
    public Guid? Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public decimal? TotalSale { get; set; }
    public bool? Canceled { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
}
