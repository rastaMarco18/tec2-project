using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CancelSales;

public class CancelSaleCommand : IRequest<CancelSaleResult>
{
    public Guid Id { get; set; }
}
