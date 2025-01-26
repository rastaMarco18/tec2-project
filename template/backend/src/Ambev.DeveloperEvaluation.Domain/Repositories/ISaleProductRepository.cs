using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleProductRepository
    {
        Task<SaleProduct> CreateAsync(SaleProduct product, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        IQueryable<SaleProduct> GetProducts(SaleProductFilter sale, CancellationToken cancellationToken = default);
    }
}
