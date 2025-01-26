using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class SaleProductRepository : ISaleProductRepository
{
    private readonly DefaultContext _context;
    public SaleProductRepository(DefaultContext context)
    {
        _context = context;
    }
    public async Task<SaleProduct> CreateAsync(SaleProduct saleProduct, CancellationToken cancellationToken = default)
    {
        await _context.SalesProducts.AddAsync(saleProduct, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return saleProduct;
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<SaleProduct> GetProducts(SaleProductFilter saleProduct, CancellationToken cancellationToken = default)
    {
        var query = _context.SalesProducts.AsQueryable();

        if (saleProduct.Id.HasValue)
            query = query.Where(x => x.Id == saleProduct.Id);

        if (saleProduct.SaleId.HasValue)
            query = query.Where(x => x.Sale_Id == saleProduct.SaleId);

        if (saleProduct.ProductId.HasValue)
            query = query.Where(x => x.Product_Id == saleProduct.ProductId);

        return query;
    }
}
