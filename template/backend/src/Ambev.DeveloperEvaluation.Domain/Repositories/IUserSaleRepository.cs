using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IUserSaleRepository
    {
        Task<UserSale> CreateAsync(UserSale userSale, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
        IQueryable<UserSale> GetUserSale(UserSaleFilter userSale, CancellationToken cancellationToken = default);
    }
}
