using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Filters
{
    public class ProductFilter : BaseFilter
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
