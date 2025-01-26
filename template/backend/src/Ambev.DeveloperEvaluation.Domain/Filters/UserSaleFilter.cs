using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Filters
{
    public class UserSaleFilter : BaseFilter
    {
        public Guid? SaleId { get; set; }
        public Guid? UserId { get; set; }
    }
}
