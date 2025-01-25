using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity
{
    public decimal TotalSale { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalSaleItems { get; set; }
    public bool Canceled { get; set; }
}
