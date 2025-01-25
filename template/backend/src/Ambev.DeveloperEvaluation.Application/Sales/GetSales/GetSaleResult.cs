using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales;

public class GetSaleResult
{
    public IQueryable<Sale>? Sales { get; set; }
}
