using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        IQueryable<Product> GetProducts(ProductFilter sale, CancellationToken cancellationToken = default);
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<List<Product>> GetProductsByIdList(List<Guid> ids, int page, int rows);
        Task<int> GetTotalById(List<Guid> ids); 
    }
}
