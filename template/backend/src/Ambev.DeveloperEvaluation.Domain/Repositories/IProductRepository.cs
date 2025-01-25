using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Creates a new Product in the repository
        /// </summary>
        /// <param name="product">The Product to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created user</returns>
        Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a Product from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the product to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the user was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return an list of Product
        /// </summary>
        /// <param name="sale">Params about Product</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created user</returns>
        IQueryable<Product> GetProducts(ProductFilter sale, CancellationToken cancellationToken = default);
    }
}
