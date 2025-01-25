using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    public decimal TotalSale { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSaleItems { get; set; }
    public bool Canceled { get; set; }
}
