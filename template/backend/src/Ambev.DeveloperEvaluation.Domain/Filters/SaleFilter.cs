using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Filters;

public class SaleFilter : BaseFilter
{
    public DateTime? CreatedAt { get; set; }
    public decimal? TotalSale { get; set; }
    public decimal? Discount { get; set; }
    public decimal? TotalSaleItems { get; set; }
    public bool? Canceled { get; set; }
}
