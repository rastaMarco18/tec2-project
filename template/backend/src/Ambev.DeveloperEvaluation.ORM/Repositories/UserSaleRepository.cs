using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class UserSaleRepository : IUserSaleRepository
    {
        private readonly DefaultContext _context;
        public UserSaleRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<UserSale> CreateAsync(UserSale userSale, CancellationToken cancellationToken = default)
        {
            await _context.UserSales.AddAsync(userSale, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return userSale;
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<UserSale> GetUserSale(UserSaleFilter userSale, CancellationToken cancellationToken = default)
        {
            var query = _context.UserSales.AsQueryable();

            if (userSale.SaleId.HasValue)
                query = query.Where(x => x.SaleId == userSale.SaleId);

            if (userSale.UserId.HasValue)
                query = query.Where(x => x.UserId == userSale.UserId);

            return query;
        }
    }
}
