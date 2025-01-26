using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;

public class GetDiscountPurchaseCommand : IRequest<GetDiscountPurchaseResult>
{
    public List<ProductPurchaseCommand> Products { get; set; }

}

public class ProductPurchaseCommand
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
