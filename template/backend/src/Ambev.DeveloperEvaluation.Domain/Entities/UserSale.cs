namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class UserSale
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SaleId { get; set; }
}
