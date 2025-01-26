using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Filters;

public class SaleProductFilter : BaseFilter
{
    public Guid? SaleId { get; set; }
    public Guid? ProductId { get; set; }
}
