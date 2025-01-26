using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class SaleRepository : ISaleRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of SaleRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        await _context.Sales.AddAsync(sale, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    public async Task<bool> Update(Sale sale, CancellationToken cancellationToken = default)
    {
        await _context.Database.ExecuteSqlRawAsync(
                "UPDATE public.\"Sales\" SET \"Canceled\" = {0}, \"UpdatedAt\" = {1} WHERE \"Id\" = {2}",
                sale.Canceled, sale.UpdatedAt, sale.Id);

        //await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    public IQueryable<Sale> GetSales(SaleFilter sale, CancellationToken cancellationToken = default)
    {
        var query = _context.Sales.AsQueryable();

        if (sale.Id.HasValue)
            query = query.Where(x => x.Id == sale.Id);

        if (sale.Canceled.HasValue)
            query = query.Where(x => x.Canceled == sale.Canceled);

        if (sale.CreatedAt.HasValue)
        {
            var startOfDay = sale.CreatedAt.Value.Date;
            var endOfDay = startOfDay.AddDays(1);
            query = query.Where(x => x.CreatedAt >= startOfDay && x.CreatedAt < endOfDay);
        }

        query = from q in query
                select new Sale()
                {
                    Id = q.Id,
                    TotalSale = q.TotalSale,
                    Discount = q.Discount,
                    TotalSaleItems = q.TotalSaleItems,
                    CreatedAt = q.CreatedAt,
                    Canceled = q.Canceled,
                    Products = (from product in _context.Products
                                join salesProducts in _context.SalesProducts on product.Id equals salesProducts.Product_Id
                                where q.Id == salesProducts.Sale_Id
                                select product).ToList()
                };

        return query;
    }
}
