using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of Product Repository
        /// </summary>
        /// <param name="context">The database context</param>
        public ProductRepository(DefaultContext context)
        {
            _context = context;
        }


        public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken = default)
        {
            await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return product;
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProducts(ProductFilter product, CancellationToken cancellationToken = default)
        {
            var query = _context.Products.AsQueryable();

            if (product.Id.HasValue)
                query = query.Where(x => x.Id == product.Id);

            if (product.CreatedAt.HasValue)
            {
                var startOfDay = product.CreatedAt.Value.Date;
                var endOfDay = startOfDay.AddDays(1);
                query = query.Where(x => x.CreatedAt >= startOfDay && x.CreatedAt < endOfDay);
            }

            if (product.Name != null)
                query = query.Where(x => x.Name.Contains(product.Name));

            return query;
        }
    }
}
